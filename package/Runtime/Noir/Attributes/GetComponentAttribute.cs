using System;
using UnityEngine;

// -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
// Fork of AutohookAttribute by the extremely talented Lotte:
// Original Source: https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22
// Donate to Lotte: https://ko-fi.com/lotte | https://t.co/E7RCjsxCFw | https://t.co/I4JELT2QzR
// Follow them on Twitter: https://twitter.com/LotteMakesStuff
// -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace Noir.Attributes {
    public enum GetComponentSearchArea {
        /// <summary>
        /// Search for the component type only on the current GameObject.
        /// </summary>
        SelfOnly,

        /// <summary>
        /// Search for the component type within the parents of the current GameObject before searching on the current GameObject.
        /// </summary>
        ParentFirst,

        /// <summary>
        /// Search for the component type within the children of the current GameObject before searching on the current GameObject.
        /// </summary>
        ChildrenFirst
    }

    /// <summary>
    /// Automatically wires up the first component that matches the annotated field type.
    /// </summary>
    /// <remarks>
    /// Wiring is done at edit time so there is no startup cost.
    /// </remarks>
    /// <seealso cref="UnityEngine.PropertyAttribute" />
    /// <seealso href="https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22">Original implementation of AutohookAttribute by Lotte</seealso>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class GetComponentAttribute : PropertyAttribute {
        /// <summary>
        /// Specifies where the component should be searched for (e.g., on the same GameObject, parent, or children).
        /// </summary>
        public GetComponentSearchArea SearchArea { get; private set; }

        /// <summary>
        /// Creates a new <see cref="GetComponentAttribute"/> with the specified search area.
        /// </summary>
        /// <param name="searchArea">The region in which to search for the component.</param>
        public GetComponentAttribute(GetComponentSearchArea searchArea = GetComponentSearchArea.SelfOnly) {
            SearchArea = searchArea;
        }
    }
}