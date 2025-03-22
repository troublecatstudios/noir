using System;
using System.Collections.Generic;

namespace Noir.Unity.DependencyInjection {
    public sealed class ServiceContainer : IServiceContainer {
        private static readonly IServiceContainer _instance = new ServiceContainer();

        public static T GetService<T>() => _instance.GetService<T>();
        public static bool IsServiceRegistered<T>() => _instance.IsServiceRegistered<T>();

        public static void RegisterService<T>(T instance) => _instance.RegisterService(instance);
        public static bool TryGetService<T>(out T instance) => _instance.TryGetService(out instance);
        public static void UnregisterService<T>() => _instance.UnregisterService<T>();

        public static IServiceContainer GetContainer() => _instance;

#if UNITY_EDITOR
        public static void Clear() => _instance.RegisteredServices.Clear();
#endif


        private readonly Dictionary<Type, object> _registeredServices = new Dictionary<Type, object>();

        public Dictionary<Type, object> RegisteredServices => _registeredServices;

        T IServiceContainer.GetService<T>() {
            if (_registeredServices.ContainsKey(typeof(T))) {
                return (T)_registeredServices[typeof(T)];
            }
            var bestMatch = LocateBestServiceMatch(typeof(T));
            if (bestMatch == null) {
                throw new NullReferenceException($"Unable to find service for {typeof(T).Name}!");
            }
            return (T)bestMatch;
        }

        bool IServiceContainer.IsServiceRegistered<T>() {
            if (_registeredServices.ContainsKey(typeof(T))) {
                return true;
            }
            var bestMatch = LocateBestServiceMatch(typeof(T));
            return bestMatch != null;
        }

        void IServiceContainer.RegisterService<T>(T instance) {
            if (IsServiceRegistered<T>()) {
                var registeredInstance = GetService<T>();
                if (registeredInstance != null) {
                    throw new Exception($"A service of type {typeof(T).Name} is already registered.");
                }
                UnregisterService<T>();
            }
            _registeredServices.Add(typeof(T), instance);
        }

        bool IServiceContainer.TryGetService<T>(out T instance) {
            instance = default;
            if (IsServiceRegistered<T>()) {
                instance = GetService<T>();
                return true;
            }
            return false;
        }

        void IServiceContainer.UnregisterService<T>() {
            if (_registeredServices.ContainsKey(typeof(T))) {
                _registeredServices.Remove(typeof(T));
            }
        }

        private object LocateBestServiceMatch(Type type) {
            foreach (var entry in _registeredServices) {
                if (entry.Key.IsAssignableFrom(type)) {
                    return entry.Value;
                }
            }
            return null;
        }
    }
}
