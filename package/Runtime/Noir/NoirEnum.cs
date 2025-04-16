using System;
using System.Collections.Generic;
using System.Linq;

namespace Noir {
    public static class NoirEnum {
        public static IEnumerable<T> AllValuesFor<T>() {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}