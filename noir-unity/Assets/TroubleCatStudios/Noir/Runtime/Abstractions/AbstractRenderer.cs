using UnityEngine;

namespace Noir.Unity.Abstractions {
    public abstract class AbstractRenderer {
        public abstract Color color { get; set; }
        public abstract void GetPropertyBlock(MaterialPropertyBlock properties);
        public abstract void SetPropertyBlock(MaterialPropertyBlock properties);
    }
}
