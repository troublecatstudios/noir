using System;
using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class UnityTransform : AbstractTransform {
        private Transform _unityTransform;
        private Transform _unityParent;

        private UnityTransform _parent;

        public UnityTransform(Transform transform) {
            _unityTransform = transform;
        }

        /// <inheritdoc cref="UnityEngine.Transform.position"/>
        public override Vector3 position {
            get => _unityTransform.position;
            set => _unityTransform.position = value;
        }

        /// <inheritdoc cref="UnityEngine.Transform.localPosition"/>
        public override Vector3 localPosition {
            get => _unityTransform.localPosition;
            set => _unityTransform.localPosition = value;
        }

        /// <inheritdoc cref="UnityEngine.Transform.parent"/>
        public override AbstractTransform parent {
            get {
                if (_unityParent == null || _unityParent != _unityTransform.parent) {
                    _unityParent = _unityTransform.parent;
                    _parent = new UnityTransform(_unityParent);
                }
                return _parent;
            }
            set {
                if (value is UnityTransform uParent) {
                    _unityParent = _unityTransform.parent = uParent._unityTransform;
                    _parent = uParent;
                    return;
                }
                throw new InvalidCastException($"Cannot convert type {value.GetType().Name} to {typeof(UnityTransform).Name}");
            }
        }

        /// <inheritdoc cref="UnityEngine.Component.gameObject"/>
        public override AbstractGameObject gameObject => new UnityGameObject(_unityTransform.gameObject);

        /// <inheritdoc cref="UnityEngine.Transform.up"/>
        public override Vector2 up => _unityTransform.up;

        /// <inheritdoc cref="UnityEngine.Transform.right"/>
        public override Vector2 right => _unityTransform.right;

        /// <inheritdoc cref="UnityEngine.Transform.forward"/>
        public override Vector2 forward => _unityTransform.forward;

        /// <inheritdoc cref="UnityEngine.Transform.rotation"/>
        public override Quaternion rotation {
            get => _unityTransform.rotation;
            set => _unityTransform.rotation = value;
        }

        /// <inheritdoc cref="UnityEngine.Component.GetComponent{T}"/>
        public override T GetComponent<T>() => _unityTransform.GetComponent<T>();

        /// <inheritdoc cref="UnityEngine.Component.GetComponentInChildren{T}"/>
        public override T GetComponentInChildren<T>() => _unityTransform.GetComponentInChildren<T>();

        /// <inheritdoc cref="UnityEngine.Component.GetComponentInParent{T}"/>
        public override T GetComponentInParents<T>() => _unityTransform.GetComponentInParent<T>();

        /// <inheritdoc cref="UnityEngine.Component.GetComponents{T}"/>
        public override T[] GetComponents<T>() => _unityTransform.GetComponents<T>();

        /// <inheritdoc cref="UnityEngine.Component.GetComponentsInChildren{T}"/>
        public override T[] GetComponentsInChildren<T>() => _unityTransform.GetComponentsInChildren<T>();

        /// <inheritdoc cref="UnityEngine.Component.GetComponentsInParent{T}"/>
        public override T[] GetComponentsInParents<T>() => _unityTransform.GetComponentsInParent<T>();

        /// <inheritdoc cref="UnityEngine.Component.CompareTag(string)"/>
        public override bool CompareTag(string tag) => _unityTransform.CompareTag(tag);

        /// <inheritdoc cref="UnityEngine.Transform.SetPositionAndRotation(Vector3, Quaternion)"/>
        public override void SetPositionAndRotation(Vector3 position, Quaternion rotation) => _unityTransform.SetPositionAndRotation(position, rotation);
    }
}
