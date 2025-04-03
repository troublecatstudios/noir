using NUnit.Framework;
using System;

namespace Noir.Testing.Assertions {
    public static class EnumAssertions {
        public static void IsFlag<T>(this ICustomAssertionContext<T> context, string message = null) where T : Enum {
            if (!Attribute.IsDefined(typeof(T), typeof(FlagsAttribute))) {
                Assert.Fail(message ?? "Expected enum to have the [Flags] attribute, but it was missing.");
            }
        }

        public static void HasFlag<T>(this ICustomAssertionContext<T> context, T flag, string message = null) where T : Enum {
            Assert.True(context.Target.HasFlag(flag), message ?? $"Expected enum to have flag '{flag}' but it was not set.");
        }
    }
}