using System;

namespace Noir.Events {
    public interface INoirEventDispatcher {
        bool DispatchEvent<T>(T eventData);
    }
}