using UnityEngine;

namespace Noir.Unity.Abstractions {
    public abstract class AbstractTransform : IComponentResolver, ILocalSpaceScope {
        public abstract Vector3 position { get; set; }

        public abstract AbstractTransform parent { get; set; }

        public abstract bool CompareTag(string tag);

        public abstract T GetComponent<T>();

        public abstract T GetComponentInChildren<T>();

        public abstract T GetComponentInParents<T>();

        public abstract T[] GetComponents<T>();

        public abstract T[] GetComponentsInChildren<T>();

        public abstract T[] GetComponentsInParents<T>();

        public abstract AbstractGameObject gameObject { get; }

        public abstract void SetPositionAndRotation(Vector3 position, Quaternion rotation);

        public abstract Vector3 localPosition { get; set; }
        public abstract Vector2 up { get; }
        public abstract Vector2 right { get; }
        public abstract Vector2 forward { get; }
        public abstract Quaternion rotation { get; set; }
    }
}
