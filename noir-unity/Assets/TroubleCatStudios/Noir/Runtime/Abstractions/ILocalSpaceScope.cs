using UnityEngine;

namespace Noir.Unity.Abstractions {
    public interface ILocalSpaceScope {
        Vector2 up { get; }
        Vector2 right { get; }
        Vector2 forward { get; }

        Quaternion rotation { get; set; }
    }
}
