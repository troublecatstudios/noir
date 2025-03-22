using System;
using UnityEngine;

// -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
// Fork of AutohookAttribute by the extremely talented Lotte:
// Original Source: https://gist.github.com/LotteMakesStuff/d6a9a4944fc667e557083108606b7d22
// Donate to Lotte: https://ko-fi.com/lotte | https://t.co/E7RCjsxCFw | https://t.co/I4JELT2QzR
// Follow them on Twitter: https://twitter.com/LotteMakesStuff
// -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace Noir.Unity.Attributes {
    public enum GetComponentSearchArea {
        Self,
        ParentFirst,
        ChildrenFirst
    }

    /// <summary>
    /// Automatically wires up the first component that matches the annotated field type.
    /// </summary>
    /// <remarks>
    /// Wiring is done at edit time so there is no startup cost.
    /// </remarks>
    /// <seealso cref="UnityEngine.PropertyAttribute" />
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class GetComponentAttribute : PropertyAttribute {
        public GetComponentSearchArea SearchArea { get; private set; }

        public GetComponentAttribute(GetComponentSearchArea searchArea = GetComponentSearchArea.Self) {
            SearchArea = searchArea;
        }
    }
}
