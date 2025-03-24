using System;
using System.Collections.Generic;
using Noir.Logging;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Noir.Events {
    public class NoirEventManager : INoirEventDispatcher, INoirEventRegistry {
        private readonly Dictionary<Type, List<GameObject>> _registry = new();

        private static readonly NoirEventManager _instance = new();
        internal static NoirEventManager Instance => _instance;

        public void Register<T>(GameObject handler) => Register(handler, typeof(T));

        public void Register(GameObject handler, Type eventDataType) {
            if (!_registry.ContainsKey(eventDataType)) {
                _registry.Add(eventDataType, new List<GameObject>() { handler });
                return;
            }
            var listeners = _registry[eventDataType];
            listeners.Add(handler);
            _registry[eventDataType] = listeners;
        }

        public void Unregister<T>(GameObject handler) => Unregister(handler, typeof(T));

        public void Unregister(GameObject handler, Type eventDataType) {
            if (!_registry.ContainsKey(eventDataType)) {
                return;
            }
            var listeners = _registry[eventDataType];
            listeners.Remove(handler);
            _registry[eventDataType] = listeners;
        }

        public bool DispatchEvent<T>(T eventData) {
            if (_registry.TryGetValue(typeof(T), out var listeners)) {
                if (NoirInternalVariableFacade.DebugShowEventDispatches) {
                    LoggerSingleton.Debug<NoirEventManager>($"Dispatching event={typeof(T).Name}, listeners={listeners.Count}");
                }

                foreach (var listener in listeners) {
                    ExecuteEvents.Execute<INoirEventListener<T>>(listener, null, (x, y) => x.EventReceived(eventData));
                }
                return true;
            }
            if (NoirInternalVariableFacade.DebugShowEventDispatches) {
                LoggerSingleton.Debug<NoirEventManager>($"Dispatching event={typeof(T).Name}, listeners=0");
            }
            LoggerSingleton.Warn<NoirEventManager>($"Unable to find a registered event handler for {typeof(T).Name}");
            return false;
        }
    }
}