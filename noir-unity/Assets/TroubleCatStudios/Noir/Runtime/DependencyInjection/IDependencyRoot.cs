using UnityEngine;

namespace Noir.DependencyInjection {
    public interface IDependencyRoot {
        GameObject gameObject { get; }
    }
}