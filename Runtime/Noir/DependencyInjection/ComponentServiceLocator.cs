using UnityEngine;

namespace Noir.DependencyInjection {
    /// <summary>
    /// Provides local component-based service resolution within a specific GameObject hierarchy.
    /// </summary>
    /// <remarks>
    /// The <see cref="ComponentServiceLocator"/> is a lightweight dependency resolver that integrates with
    /// the global <see cref="ServiceLocator"/> pattern. It first attempts to retrieve a requested service
    /// from the globally registered container, and if unavailable, searches for matching components in the
    /// provided GameObject, its parents, or its children.
    ///
    /// This allows systems to mix global and local dependency injection patterns seamlessly —
    /// e.g., when a system requires context-specific components like localized managers or scene-level services.
    /// </remarks>
    public class ComponentServiceLocator {
        private readonly GameObject _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentServiceLocator"/> class, binding it to a
        /// specified GameObject hierarchy.
        /// </summary>
        /// <param name="container">
        /// The GameObject that defines the starting point for dependency resolution.
        /// </param>
        /// <remarks>
        /// If the provided GameObject or any of its parents implement <see cref="IDependencyRoot"/>,
        /// that GameObject becomes the dependency root for all future resolutions.
        /// </remarks>
        public ComponentServiceLocator(GameObject container) {
            _container = FindDependencyRoot(container);
        }

        /// <summary>
        /// Resolves a service or component of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of service or component to retrieve.</typeparam>
        /// <returns>
        /// The resolved service instance if found; otherwise, <c>null</c>.
        /// </returns>
        /// <remarks>
        /// The lookup order is:
        /// <list type="number">
        /// <item><description>Global <see cref="ServiceLocator"/></description></item>
        /// <item><description>Attached component on the dependency root</description></item>
        /// <item><description>Child components</description></item>
        /// <item><description>Parent components</description></item>
        /// </list>
        /// </remarks>
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

        /// <summary>
        /// Attempts to resolve a service or component of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of service or component to retrieve.</typeparam>
        /// <param name="instance">The resulting service instance if found.</param>
        /// <returns>
        /// <c>true</c> if the service was found; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Uses the same resolution order as <see cref="GetService{T}"/>, but does not throw exceptions or
        /// assume the result exists.
        /// </remarks>
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

        /// <summary>
        /// Finds the nearest dependency root GameObject starting from a specified target.
        /// </summary>
        /// <param name="target">The starting GameObject to search from.</param>
        /// <returns>
        /// The GameObject that implements <see cref="IDependencyRoot"/>, or the original target
        /// if no such root exists in the hierarchy.
        /// </returns>
        /// <remarks>
        /// This ensures that the <see cref="ComponentServiceLocator"/> resolves services relative
        /// to the most contextually appropriate GameObject in a scene or prefab hierarchy.
        /// </remarks>
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