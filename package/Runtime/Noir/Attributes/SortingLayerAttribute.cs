using System;
using UnityEngine;

namespace Noir.Attributes {
    /// <summary>
    /// Displays a dropdown of available sorting layers for the annotated field in the Unity Inspector.
    /// </summary>
    /// <remarks>
    /// This attribute is typically applied to a <see cref="string"/> or <see cref="int"/> field to make it easier
    /// to select and assign a sorting layer without manually typing its name or ID.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class SortingLayerAttribute : PropertyAttribute { }
}