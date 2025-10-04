using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    public static class EnumAssertions {
        /// <summary>
        /// Asserts that the enum has the <c>[Flags]</c> attribute.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        public static void IsFlag<T>(this IAssertionContext<T> context, string message = null) where T : Enum {
            if (!Attribute.IsDefined(typeof(T), typeof(FlagsAttribute))) {
                Assert.Fail(message ?? "Expected enum to have the [Flags] attribute, but it was missing.");
            }
        }

        /// <summary>
        /// Asserts that the enum contains the given enum value as a flag.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="flag"></param>
        /// <param name="message"></param>
        /// <typeparam name="T"></typeparam>
        public static void HasFlag<T>(this IAssertionContext<T> context, T flag, string message = null) where T : Enum {
            Assert.True(context.Target.HasFlag(flag), message ?? $"Expected enum to have flag '{flag}' but it was not set.");
        }
    }
}