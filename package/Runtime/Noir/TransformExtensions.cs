using UnityEngine;

namespace Noir {
    public static class TransformExtensions {
        public static bool TryFind<T>(this Transform transform, string name, out T component) where T : Component {
            component = null;
            var t = transform.Find(name);
            if (t && t.TryGetComponent<T>(out component)) {
                return true;
            }
            return false;
        }
    }
}