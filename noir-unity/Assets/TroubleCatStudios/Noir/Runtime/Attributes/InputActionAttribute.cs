using System;
using UnityEngine;

namespace Noir.Attributes {
#if ENABLE_INPUT_SYSTEM

    /// <summary>
    /// Marks a <see cref="string"/> field type with a custom editor to allow picking an input action via the inspector UI.
    /// </summary>
    /// <remarks>
    /// This attribute is only available if the new Unity Input System has been installed in the project.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class InputActionAttribute : PropertyAttribute {
    }
#endif
}