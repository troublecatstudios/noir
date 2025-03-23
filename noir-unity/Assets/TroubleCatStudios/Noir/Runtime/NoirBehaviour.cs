using Noir.DependencyInjection;
using System;
using Noir.Events;
using Noir.Logging;
using UnityEngine;

namespace Noir {
    public class NoirBehaviour : MonoBehaviour {
        private readonly Guid _guid = Guid.NewGuid();
        private ComponentServiceLocator _services = null;
        protected BehaviourLogger Logger => new(this);

        protected GameTime GameTime => ServiceLocator.GetService<GameTime>();

        protected void DispatchEvent<T>(T eventInfo) {
            ServiceLocator.GetService<INoirEventDispatcher>().DispatchEvent<T>(eventInfo);
        }

        protected void RegisterListener<T>() {
            ServiceLocator.GetService<INoirEventRegistry>().Register<T>(gameObject);
        }

        protected void UnregisterListener<T>() {
            ServiceLocator.GetService<INoirEventRegistry>().Unregister<T>(gameObject);
        }

        protected ComponentServiceLocator Services {
            get {
                if (_services == null) _services = new(gameObject);
                return _services;
            }
        }

        public override string ToString() {
            return $"id={_guid}";
        }
    }
}