using System;
using UnityEngine;

namespace Noir.Unity.Attributes {
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class SortingLayerAttribute : PropertyAttribute { }
}
