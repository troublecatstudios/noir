using UnityEngine;

namespace Noir.DependencyInjection {
    public class ComponentServiceLocator {
        private readonly GameObject _container;
        public ComponentServiceLocator(GameObject container) {
            _container = FindDependencyRoot(container);
        }

        public T GetService<T>() {
            if (ServiceLocator.TryGetService<T>(out var svc)) {
                return svc;
            }
            svc = _container.GetComponent<T>();
            if (svc == null) {
                svc = _container.GetComponentInChildren<T>();
                if (svc == null) {
                    svc = _container.GetComponentInParent<T>();
                }
            }
            return svc;
        }

        public bool TryGetService<T>(out T instance) {
            if (ServiceLocator.TryGetService<T>(out var svc)) {
                instance = svc;
                return true;
            }
            instance = _container.GetComponent<T>();
            if (instance == null) {
                instance = _container.GetComponentInChildren<T>();
                if (instance == null) {
                    instance = _container.GetComponentInParent<T>();
                }
            }
            return instance != null;
        }

        private GameObject FindDependencyRoot(GameObject target) {
            IDependencyRoot root = null;
            if (target.TryGetComponent<IDependencyRoot>(out root)) {
                return target;
            }
            root = target.GetComponentInParent<IDependencyRoot>();
            if (root != null) {
                return root.gameObject;
            }
            return target;
        }
    }
}