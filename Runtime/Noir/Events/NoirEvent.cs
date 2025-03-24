using System;
using System.Collections.Generic;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Noir.Events {
    [CreateAssetMenu(fileName = "NoirEvent.asset", menuName = "Noir/Event")]
    public class NoirEvent : ScriptableObject {
        private readonly List<InternalListenerWrapper> _listeners = new List<InternalListenerWrapper>();

#if ODIN_INSPECTOR
        [ShowInInspector]
        [DisplayAsString]
        [TableColumnWidth(100, Resizable = true)]
#endif
        public string Name => name;

#if ODIN_INSPECTOR
        [Button]
        [VerticalGroup("Actions")]
        [TableColumnWidth(90, Resizable = false)]
#endif
        public void Invoke() {
            if (!Application.isPlaying) return;
            Debug.Log($"NoirEvent [{name}] INFO Invoke", this);
            foreach (var listener in _listeners) listener.RaiseEvent();
        }

        public void Invoke(object context) {
            if (!Application.isPlaying) return;
            Debug.Log($"NoirEvent [{name}] INFO Invoke context={context}", this);
            foreach (var listener in _listeners) listener.RaiseEvent(context);
        }

#if ODIN_INSPECTOR
        [ShowInInspector]
        [ReadOnly]
        [TableColumnWidth(80, Resizable = false)]
#endif
        public bool IsSubscribed => _listeners.Count > 0;

#if ODIN_INSPECTOR
        [ShowInInspector]
        [TableColumnWidth(120, Resizable = true)]
#endif
        private InternalListenerWrapper[] Subscribers => _listeners.ToArray();

#if ODIN_INSPECTOR
        [ShowInInspector]
        [ReadOnly]
        [DisplayAsString]
        [TableColumnWidth(120, Resizable = false)]
#endif
        public int SubscriberCount => _listeners.Count;

        public void Register(MonoBehaviour behaviour, Action callback) {
            var wrapper = new InternalListenerWrapper(behaviour, callback);
            Register(behaviour, wrapper);
        }

        public void Register(MonoBehaviour behaviour, Action<object> callback) {
            var wrapper = new InternalListenerWrapper(behaviour, callback);
            Register(behaviour, wrapper);
        }

        public void Unregister(MonoBehaviour behaviour, Action<object> callback) {
            var tempWrapper = new InternalListenerWrapper(behaviour, callback);
            Unregister(behaviour, tempWrapper);
        }

        public void Unregister(MonoBehaviour behaviour, Action callback = null) {
            var tempWrapper = new InternalListenerWrapper(behaviour, callback);
            Unregister(behaviour, tempWrapper);
        }

        private void Register(MonoBehaviour behaviour, InternalListenerWrapper wrapper) {
            if (!_listeners.Contains(wrapper))
                _listeners.Add(wrapper);
            else
                Debug.LogWarning($"Could not register behaviour '{behaviour.name}' on '{behaviour.gameObject}' to event '{name}'. It is already registered.", behaviour.gameObject);
        }

        private void Unregister(MonoBehaviour behaviour, InternalListenerWrapper tempWrapper) {
            int idx = 0;
            bool matched = false;
            while (idx < _listeners.Count) {
                var wrapper = _listeners[idx];
                if (wrapper.Equals(behaviour)) {
                    _listeners.RemoveAt(idx);
                    continue;
                }
                idx++;
            }
            if (!matched) {
                Debug.LogWarning($"Could not unregister behaviour '{behaviour.GetType().Name}' on '{behaviour.gameObject}' from event '{name}'. It was not registered.", behaviour.gameObject);
            }
        }

        [Serializable]
        private class InternalListenerWrapper : INoirEventListener {
            private MonoBehaviour _target;
            private Action<object> _callback;

            public InternalListenerWrapper(MonoBehaviour target, Action callback) {
                _target = target;
                _callback = (o) => callback();
            }

            public InternalListenerWrapper(MonoBehaviour target, Action<object> callback) {
                _target = target;
                _callback = callback;
            }

#if UNITY_EDITOR
#if ODIN_INSPECTOR
            [Button(Name = "@this._target.name")]
#endif
            private void SelectTarget() {
                UnityEditor.Selection.activeObject = _target.gameObject;
            }
#endif

            public void RaiseEvent(object o = null) => _callback?.Invoke(o);

            public bool Equals(MonoBehaviour behaviour) {
                return behaviour == _target && behaviour.gameObject == _target.gameObject;
            }

            public override bool Equals(object obj) => obj.GetHashCode() == GetHashCode() || obj.GetHashCode() == _target.GetInstanceID();

            public override int GetHashCode() => (_target?.GetInstanceID() ?? 0) + (_callback?.GetHashCode() ?? 0);
        }
    }
}