using System;
using System.Collections.Generic;

namespace Noir {
    public sealed class ServiceLocator : IServiceLocator {
        private static readonly IServiceLocator _instance = new ServiceLocator();

        public static T GetService<T>() => _instance.GetService<T>();
        public static bool IsServiceRegistered<T>() => _instance.IsServiceRegistered<T>();

        public static void RegisterService<T>(T instance) => _instance.RegisterService(instance);
        public static void RegisterService<T, TImplementation>() where TImplementation : T, new() => _instance.RegisterService<T>(new TImplementation());
        public static void RegisterService<T>(Func<T> factory) => _instance.RegisterService(factory);
        public static bool TryGetService<T>(out T instance) => _instance.TryGetService(out instance);
        public static void UnregisterService<T>() => _instance.UnregisterService<T>();

        public static IServiceLocator GetProvider() => _instance;

        internal static ServiceLocator InternalInstance => _instance as ServiceLocator;

#if UNITY_EDITOR
        public static void Clear() => _instance.Registry.Clear();
#endif


        private readonly Dictionary<Type, object> _serviceRegistry = new();
        private readonly Dictionary<Type, Func<object>> _factories = new();

        public Dictionary<Type, object> Registry => _serviceRegistry;

        internal IEnumerable<(Type, Type)> RegisteredTypes() {
            foreach (var (interfaceType, concrete) in _serviceRegistry) {
                yield return (interfaceType, concrete.GetType());
            }

            foreach (var (interfaceType, funcAccessor) in _factories) {
                var func = funcAccessor();
                var genericArgs = func.GetType().GetGenericArguments();
                if (genericArgs.Length > 0) {
                    yield return (interfaceType, genericArgs[0]);
                } else {
                    var returnType = func.GetType().GetMethod("Invoke").ReturnType;
                    yield return (interfaceType, returnType);
                }
            }
        }

        T IServiceLocator.GetService<T>() {
            if (_serviceRegistry.ContainsKey(typeof(T))) {
                return (T)_serviceRegistry[typeof(T)];
            }
            if (_factories.ContainsKey(typeof(T))) {
                // the object hasn't been built yet
                // call the factory and store the result
                var factoryAccessor = _factories[typeof(T)];
                if (factoryAccessor() is Func<T> factory) {
                    var instance = factory();
                    _factories.Remove(typeof(T));
                    _serviceRegistry.Add(typeof(T), instance);
                    return instance;
                }
            }
            var bestMatch = LocateBestServiceMatch(typeof(T));
            if (bestMatch == null) {
                throw new NullReferenceException($"Unable to find service for {typeof(T).Name}!");
            }
            return (T)bestMatch;
        }

        bool IServiceLocator.IsServiceRegistered<T>() {
            if (_serviceRegistry.ContainsKey(typeof(T))) {
                return true;
            }
            if (_factories.ContainsKey(typeof(T))) {
                return true;
            }
            var bestMatch = LocateBestServiceMatch(typeof(T));
            return bestMatch != null;
        }

        void IServiceLocator.RegisterService<T>(T instance) {
            if (IsServiceRegistered<T>()) {
                var registeredInstance = GetService<T>();
                if (registeredInstance != null) {
                    throw new Exception($"A service of type {typeof(T).Name} is already registered.");
                }
                UnregisterService<T>();
            }
            _serviceRegistry.Add(typeof(T), instance);
        }

        void IServiceLocator.RegisterService<T>(System.Func<T> factory) {
            if (IsServiceRegistered<T>()) {
                var registeredInstance = GetService<T>();
                if (registeredInstance != null) {
                    throw new Exception($"A service of type {typeof(T).Name} is already registered.");
                }
                UnregisterService<T>();
            }
            _factories.Add(typeof(T), () => factory);
        }

        bool IServiceLocator.TryGetService<T>(out T instance) {
            instance = default;
            if (IsServiceRegistered<T>()) {
                instance = GetService<T>();
                return true;
            }
            return false;
        }

        void IServiceLocator.UnregisterService<T>() {
            if (_serviceRegistry.ContainsKey(typeof(T))) {
                _serviceRegistry.Remove(typeof(T));
            }
            if (_factories.ContainsKey(typeof(T))) {
                _factories.Remove(typeof(T));
            }
        }

        private object LocateBestServiceMatch(Type type) {
            foreach (var entry in _serviceRegistry) {
                if (entry.Key.IsAssignableFrom(type)) {
                    return entry.Value;
                }
            }
            return null;
        }
    }
}