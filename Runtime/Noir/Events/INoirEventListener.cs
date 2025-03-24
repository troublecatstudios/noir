using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.EventSystems;

namespace Noir.Events {
    public interface INoirEventListener {
        void RaiseEvent(object o = null);
    }

    public interface INoirEventListener<T> : IEventSystemHandler {
        void EventReceived(T eventInfo);
    }
}