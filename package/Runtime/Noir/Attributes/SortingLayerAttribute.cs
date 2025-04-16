using System;
using UnityEngine;

namespace Noir.Attributes {
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class SortingLayerAttribute : PropertyAttribute { }
}