using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for working with <see cref="Enum"/> types.
    /// </summary>
    public static class EnumAssertions {
        /// <summary>
        /// Asserts that the enum type is decorated with the <see cref="FlagsAttribute"/>.
        /// </summary>
        /// <typeparam name="T">The enum type being asserted.</typeparam>
        /// <param name="context">The assertion context containing the target enum value.</param>
        /// <param name="message">An optional custom message to include if the assertion fails.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the enum type does not have the <see cref="FlagsAttribute"/> applied.
        /// </exception>
        public static void IsFlag<T>(this IAssertionContext<T> context, string message = null) where T : Enum {
            if (!Attribute.IsDefined(typeof(T), typeof(FlagsAttribute))) {
                Assert.Fail(message ?? "Expected enum to have the [Flags] attribute, but it was missing.");
            }
        }

        /// <summary>
        /// Asserts that the enum value includes the specified flag.
        /// </summary>
        /// <typeparam name="T">The enum type being asserted.</typeparam>
        /// <param name="context">The assertion context containing the target enum value.</param>
        /// <param name="flag">The flag value expected to be set on the enum.</param>
        /// <param name="message">An optional custom message to include if the assertion fails.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the target enum value does not include the specified flag.
        /// </exception>
        public static void HasFlag<T>(this IAssertionContext<T> context, T flag, string message = null) where T : Enum {
            Assert.True(context.Target.HasFlag(flag), message ?? $"Expected enum to have flag '{flag}' but it was not set.");
        }
    }
}