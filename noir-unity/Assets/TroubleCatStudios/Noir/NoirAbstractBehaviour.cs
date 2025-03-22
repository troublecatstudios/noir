using Noir.Unity.Abstractions;
using Noir.Unity.Abstractions.Impl;
using Noir.Unity.DependencyInjection;
using UnityEngine;

namespace Noir.Unity {
    public abstract class NoirAbstractBehaviour : MonoBehaviour {
        private AbstractTransform _transform;

        protected virtual void Awake() { }
        protected virtual void Start() { }
        protected virtual void Update() { }
        protected virtual void LateUpdate() { }
        protected virtual void FixedUpdate() { }
        protected virtual void OnEnable() { }
        protected virtual void OnDisable() { }
        protected virtual void OnDestroy() { }

        protected IServiceContainer Container => ServiceContainer.GetContainer();

        public AbstractTransform Transform {
            get {
                if (_transform == null) {
                    _transform = new UnityTransform(transform);
                }
                return _transform;
            }
        }

        public Vector3 Position => Transform.position;
        public Vector2 Position2D => Position;
    }
}
