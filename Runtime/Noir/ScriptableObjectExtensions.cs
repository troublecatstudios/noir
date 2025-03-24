using UnityEngine;

namespace Noir {
    public static class ScriptableObjectExtensions {
        public static string ToLogStringSafe(this ScriptableObject so) => $"{so?.name ?? "null"}";
    }
}