using UnityEngine;

namespace Noir.Unity.Abstractions.Impl {
    public class ScopedComponentResolver : IComponentResolver {
        private readonly AbstractTransform _scope;

        public ScopedComponentResolver(AbstractTransform scope) {
            _scope = scope;
        }

        public ScopedComponentResolver(Transform scope) {
            _scope = new UnityTransform(scope);
        }

        public T GetComponent<T>() => _scope.GetComponent<T>();

        public T GetComponentInChildren<T>() => _scope.GetComponentInChildren<T>();

        public T GetComponentInParents<T>() => _scope.GetComponentInParents<T>();

        public T[] GetComponents<T>() => _scope.GetComponents<T>();

        public T[] GetComponentsInChildren<T>() => _scope.GetComponentsInChildren<T>();

        public T[] GetComponentsInParents<T>() => _scope.GetComponentsInParents<T>();
    }
}
