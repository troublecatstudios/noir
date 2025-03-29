using System;
using System.Collections.Generic;

namespace Noir {
    public interface IServiceLocator {
        T GetService<T>();
        bool TryGetService<T>(out T instance);

        void RegisterService<T>(T instance);
        void RegisterService<T>(Func<T> factory);
        void UnregisterService<T>();

        bool IsServiceRegistered<T>();
    }
}