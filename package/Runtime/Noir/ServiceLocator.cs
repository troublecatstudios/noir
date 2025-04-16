using System;
using System.Collections.Generic;

namespace Noir {
    /// <summary>
    /// Provides access to services by finding an appropriate provider while hiding both the provider’s concrete type and the process used to locate it.
    /// </summary>
    /// <remarks>
    ///     <list type="bullet">
    ///         <item>It's best to limit calls to ServiceLocator methods the startup of your components: <c>Awake()</c>, <c>Start()</c>, <c>OnEnable()</c> are all good points to register and get services.</item>
    ///         <item>Avoid calling the service locator within loops or <c>Update()</c> and <c>LateUpdate()</c>.</item>
    ///         <item>When registering with the service locator, it's best to register an interface or abstract class as the lookup type.</item>
    ///     </list>
    /// </remarks>
    public sealed class ServiceLocator : IServiceLocator {
        private static readonly IServiceLocator _instance = new ServiceLocator();

        /// <summary>
        /// Gets an implementation for the given type from the service registry.
        /// </summary>
        /// <typeparam name="TServiceType">The type to use when looking up the implementation.</typeparam>
        /// <returns>An implementation of the type within the service registry.</returns>
        /// <exception cref="NullReferenceException">Thrown if no implementation for the TServiceType can be found in the service registry.</exception>
        public static TServiceType GetService<TServiceType>() => _instance.GetService<TServiceType>();

        /// <summary>
        /// Returns a value indicating whether the given service type has an implementation in the service registry.
        /// </summary>
        /// <typeparam name="TServiceType">The type to use when looking up the implementation.</typeparam>
        /// <returns><c>true</c> if the given service type has an implementation in the service registry, <c>false</c> otherwise.</returns>
        public static bool IsServiceRegistered<TServiceType>() => _instance.IsServiceRegistered<TServiceType>();

        /// <summary>
        /// Registers a service implementation in the service registry.
        /// </summary>
        /// <param name="instance"></param>
        /// <typeparam name="TServiceType">The type to use when storing the implementation.</typeparam>
        /// <remarks>
        /// This should be avoided unless absolutely necessary as it can force the parent scope to avoid garbage collection until the implementation is removed from the service registry.
        /// </remarks>
        /// <example>
        /// Registering an already created implementation.
        ///     <code>
        ///     <![CDATA[
        ///         var implementation = new ImplementationType(any, constructor, arguments);
        ///         ServiceLocator.RegisterService<InterfaceType>(implementation);
        ///     ]]>
        ///     </code>
        /// </example>
        public static void RegisterService<TServiceType>(TServiceType instance) => _instance.RegisterService(instance);

        /// <summary>
        /// Registers a service type and its implementation in the service registry.
        /// </summary>
        /// <typeparam name="TServiceType">The type to use when storing the implementation.</typeparam>
        /// <typeparam name="TImplementationType">The type that will be instantiated when the service is first retrieved.</typeparam>
        /// <remarks>
        /// The TImplementationType must be able to instantiated via an empty constructor, e.g. new TImplementationType()
        /// </remarks>
        /// <example>
        /// Registering a service.
        ///     <code>
        ///     <![CDATA[
        ///         ServiceLocator.RegisterService<TServiceType, TImplementationType>();
        ///     ]]>
        ///     </code>
        /// </example>
        public static void RegisterService<TServiceType, TImplementationType>() where TImplementationType : TServiceType, new() => _instance.RegisterService<TServiceType>(new TImplementationType());

        /// <summary>
        /// Registers a service type and its factory in the service registry.
        /// </summary>
        /// <param name="factory">A function that returns a new instance of the service type. Will be called once, when the service is first retrieved from the registry.</param>
        /// <typeparam name="TServiceType">The type to use when storing the implementation.</typeparam>
        /// <remarks>
        /// The passed factory function will be invoked when the service is first requested.
        /// </remarks>
        /// <example>
        /// Registering a service with a factory function.
        ///     <code>
        ///     <![CDATA[
        ///         ServiceLocator.RegisterService<InterfaceType>(() => new ImplementationType(any, constructor, arguments));
        ///     ]]>
        ///     </code>
        /// </example>
        public static void RegisterService<TServiceType>(Func<TServiceType> factory) => _instance.RegisterService(factory);

        /// <summary>
        /// Tries to return an implementation for the given service type.
        /// </summary>
        /// <param name="instance">The service implementation, if one exists within the service registry.</param>
        /// <typeparam name="TServiceType">The type to use when looking up the implementation.</typeparam>
        /// <returns><c>true</c> if an implementation was found in the service registry, <c>false</c> otherwise.</returns>
        public static bool TryGetService<TServiceType>(out TServiceType instance) => _instance.TryGetService(out instance);

        /// <summary>
        /// Removes a service implementation from the service registry.
        /// </summary>
        /// <typeparam name="TServiceType">The type to use when looking up the implementation.</typeparam>
        public static void UnregisterService<TServiceType>() => _instance.UnregisterService<TServiceType>();

        internal static ServiceLocator InternalInstance => _instance as ServiceLocator;

#if UNITY_EDITOR
        public static void Clear() => InternalInstance.Registry.Clear();
#endif


        private readonly Dictionary<Type, object> _serviceRegistry = new();
        private readonly Dictionary<Type, Func<object>> _factories = new();

        internal Dictionary<Type, object> Registry => _serviceRegistry;

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