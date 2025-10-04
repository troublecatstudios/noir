using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class EnumerableAssertions {
        /// <summary>
        /// Asserts that the enumerable contains the expected value.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="item"></param>
        /// <typeparam name="T"></typeparam>
        public static void Contains<T>(this IAssertionContext<IEnumerable<T>> context, T item) {
            Assert.That(context.Target, Has.Exactly(1).EqualTo(item));
        }

        /// <summary>
        /// Asserts that the enumerable has the expected length.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="length"></param>
        public static void HasLength(this IAssertionContext<IEnumerable> context, int length) {
            int count = 0;
            var en = context.Target.GetEnumerator();
            while (en.MoveNext()) {
                count++;
            }
            Assert.That(count, Is.EqualTo(length));
        }

        /// <summary>
        /// Asserts that the enumerable has the same contents as the expected enumerable.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="expected"></param>
        public static void HasSameContents(this IAssertionContext<IEnumerable> context, IEnumerable expected) {
            var act = context.Target.GetEnumerator();
            var exp = expected.GetEnumerator();
            while (act.MoveNext() && exp.MoveNext()) {
                Assert.That(act.Current, Is.EqualTo(exp.Current));
            }
        }
    }
}