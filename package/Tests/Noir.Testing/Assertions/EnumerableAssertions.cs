using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Noir.Testing.Assertions {
    /// <summary>
    /// Provides assertion extensions for verifying the contents and structure of <see cref="IEnumerable"/> and <see cref="IEnumerable{T}"/> collections.
    /// </summary>
    public static class EnumerableAssertions {
        /// <summary>
        /// Asserts that the enumerable contains the specified item.
        /// </summary>
        /// <typeparam name="T">The type of elements contained in the enumerable.</typeparam>
        /// <param name="context">The assertion context containing the target enumerable.</param>
        /// <param name="item">The item expected to be found within the enumerable.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the enumerable does not contain the specified item.
        /// </exception>
        public static void Contains<T>(this IAssertionContext<IEnumerable<T>> context, T item) {
            Assert.That(context.Target, Has.Exactly(1).EqualTo(item));
        }

        /// <summary>
        /// Asserts that the enumerable contains the expected number of elements.
        /// </summary>
        /// <param name="context">The assertion context containing the target enumerable.</param>
        /// <param name="length">The expected number of elements in the enumerable.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the enumerable length does not match the expected value.
        /// </exception>
        public static void HasLength(this IAssertionContext<IEnumerable> context, int length) {
            int count = 0;
            var en = context.Target.GetEnumerator();
            while (en.MoveNext()) {
                count++;
            }
            Assert.That(count, Is.EqualTo(length));
        }

        /// <summary>
        /// Asserts that the enumerable contains the same elements in the same order as another enumerable.
        /// </summary>
        /// <param name="context">The assertion context containing the target enumerable.</param>
        /// <param name="expected">The enumerable whose contents are expected to match the target.</param>
        /// <exception cref="AssertionException">
        /// Thrown if the enumerables differ in element count, order, or content.
        /// </exception>
        public static void HasSameContents(this IAssertionContext<IEnumerable> context, IEnumerable expected) {
            var act = context.Target.GetEnumerator();
            var exp = expected.GetEnumerator();
            while (act.MoveNext() && exp.MoveNext()) {
                Assert.That(act.Current, Is.EqualTo(exp.Current));
            }
        }
    }
}