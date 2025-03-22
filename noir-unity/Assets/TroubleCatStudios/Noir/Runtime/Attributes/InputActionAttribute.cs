using System;
using UnityEngine;

namespace Noir.Unity.Attributes {
#if ENABLE_INPUT_SYSTEM
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class InputActionAttribute : PropertyAttribute {
    }
#endif
}
