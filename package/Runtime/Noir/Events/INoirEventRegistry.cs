using System;
using UnityEngine;

namespace Noir.Events {
    public interface INoirEventRegistry {
        void Register<T>(GameObject handler);
        void Register(GameObject handler, Type eventDataType);
        void Unregister<T>(GameObject handler);
        void Unregister(GameObject handler, Type eventDataType);
    }
}