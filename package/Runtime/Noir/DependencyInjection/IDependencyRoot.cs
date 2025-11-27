using UnityEngine;
// ReSharper disable InconsistentNaming

namespace Noir.DependencyInjection {
    /// <summary>
    /// Defines a root object for a localized dependency context within the Noir dependency system.
    /// </summary>
    /// <remarks>
    /// Classes implementing <see cref="IDependencyRoot"/> mark a GameObject as the root boundary for
    /// dependency resolution when using the <see cref="ComponentServiceLocator"/>.
    ///
    /// This allows developers to define self-contained dependency contexts within prefabs,
    /// subsystems, or scenes — ensuring that <see cref="ComponentServiceLocator"/> instances
    /// can resolve services relative to a specific hierarchy instead of always relying on
    /// the global <see cref="ServiceLocator"/>.
    ///
    /// For example, a UI panel or scene controller may implement <see cref="IDependencyRoot"/>
    /// so that its child components can find context-specific services (like data providers
    /// or local managers) without polluting the global dependency graph.
    /// </remarks>
    public interface IDependencyRoot {
        /// <summary>
        /// The GameObject that defines the root of this dependency context.
        /// </summary>
        /// <remarks>
        /// Implementations should typically return the GameObject that the implementing component
        /// is attached to. This property allows the <see cref="ComponentServiceLocator"/> to traverse
        /// hierarchies and identify the correct context root.
        /// </remarks>
        GameObject gameObject { get; }
    }
}