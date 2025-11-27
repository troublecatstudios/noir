using System;
using UnityEngine;

namespace Noir.Attributes {
    /// <summary>
    /// Displays a dropdown list of available Unity tags for the annotated field in the Inspector.
    /// </summary>
    /// <remarks>
    /// This attribute is typically applied to a <see cref="string"/> field, allowing you to select a tag
    /// from Unity’s tag manager instead of manually typing it.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class TagListAttribute : PropertyAttribute {
    }
}