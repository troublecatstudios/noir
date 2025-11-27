using System;
using UnityEngine;

namespace Noir.Attributes {
    /// <summary>
    /// Indicates that the annotated field represents a Unity scene reference.
    /// </summary>
    /// <remarks>
    /// This attribute can be used to customize how scene fields are displayed in the Unity Inspector,
    /// typically allowing developers to select scenes from the project’s build settings or asset list.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field)]
    public class SceneAttribute : PropertyAttribute {
    }
}