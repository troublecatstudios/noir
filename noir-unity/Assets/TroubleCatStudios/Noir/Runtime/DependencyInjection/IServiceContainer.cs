using System;
using System.Collections.Generic;

namespace Noir.Unity.DependencyInjection {
    public interface IServiceContainer {
        Dictionary<Type, object> RegisteredServices { get; }

        T GetService<T>();
        bool TryGetService<T>(out T instance);

        void RegisterService<T>(T instance);
        void UnregisterService<T>();

        bool IsServiceRegistered<T>();
    }
}
