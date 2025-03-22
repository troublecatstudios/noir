using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noir.Unity.Extensions {
    public static class IntExtensions {
        public static int Clamp(this int value, int min = int.MinValue, int max = int.MaxValue) {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
