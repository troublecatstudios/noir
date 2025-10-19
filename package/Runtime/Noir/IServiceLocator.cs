using System;
using System.Collections.Generic;

namespace Noir {
    /// <summary>
    /// Defines a contract for a service locator that provides registration,
    /// retrieval, and management of services by type.
    /// </summary>
    public interface IServiceLocator {
        /// <summary>
        /// Retrieves a registered service of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the service to retrieve.</typeparam>
        /// <returns>The instance of the requested service.</returns>
        T GetService<T>();

        /// <summary>
        /// Attempts to retrieve a registered service of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the service to retrieve.</typeparam>
        /// <param name="instance">
        /// When this method returns, contains the service instance if found; otherwise, the default value for the type.
        /// </param>
        /// <returns><c>true</c> if the service was successfully retrieved; otherwise, <c>false</c>.</returns>
        bool TryGetService<T>(out T instance);

        /// <summary>
        /// Registers a specific instance as a service of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the service to register.</typeparam>
        /// <param name="instance">The service instance to register.</param>
        void RegisterService<T>(T instance);

        /// <summary>
        /// Registers a factory method for creating a service of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the service to register.</typeparam>
        /// <param name="factory">A factory function that produces a new service instance when called.</param>
        void RegisterService<T>(Func<T> factory);

        /// <summary>
        /// Unregisters a previously registered service of the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the service to unregister.</typeparam>
        void UnregisterService<T>();

        /// <summary>
        /// Determines whether a service of the specified type is registered.
        /// </summary>
        /// <typeparam name="T">The type of the service to check.</typeparam>
        /// <returns><c>true</c> if the service is registered; otherwise, <c>false</c>.</returns>
        bool IsServiceRegistered<T>();
    }
}