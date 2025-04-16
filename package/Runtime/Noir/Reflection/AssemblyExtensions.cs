using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Noir.Reflection {
    internal static class AssemblyExtensions {
        /// <summary>
        /// Safely returns the set of loadable types from an assembly.
        /// </summary>
        /// <param name="assembly">The <see cref="Assembly"/> from which to load types.</param>
        /// <returns>
        /// The set of types from the <paramref name="assembly" />, or the subset
        /// of types that could be loaded if there was any error.
        /// </returns>
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly) {
            if (assembly == null) {
                return Enumerable.Empty<Type>();
            }

            try {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException exception) {
                return exception.Types.Where(type => type != null);
            }
        }
    }
}
