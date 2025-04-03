using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Noir.Testing.Assertions {
    public static class EnumerableAssertions {
        public static void Contains<T>(this ICustomAssertionContext<IEnumerable<T>> context, T item) {
            Assert.That(context.Target, Has.Exactly(1).EqualTo(item));
        }

        public static void HasLength(this ICustomAssertionContext<IEnumerable> context, int length) {
            int count = 0;
            var en = context.Target.GetEnumerator();
            while (en.MoveNext()) {
                count++;
            }
            Assert.That(count, Is.EqualTo(length));
        }

        public static void HasSameContents(this ICustomAssertionContext<IEnumerable> context, IEnumerable expected) {
            var act = context.Target.GetEnumerator();
            var exp = expected.GetEnumerator();
            while (act.MoveNext() && exp.MoveNext()) {
                Assert.That(act.Current, Is.EqualTo(exp.Current));
            }
        }
    }
}