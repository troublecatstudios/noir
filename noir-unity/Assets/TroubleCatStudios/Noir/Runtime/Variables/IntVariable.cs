﻿using System;
using UnityEngine;

namespace Noir.Variables {
    [CreateAssetMenu(fileName = "IntVariable.asset", menuName = "Noir/Data/Int Variable", order = 0)]
    public class IntVariable : DataVariable<int>, IEquatable<IntVariable>, IEquatable<DataVariable<int>>, IEquatable<FloatVariable>, IEquatable<DataVariable<float>> {
        public static int operator +(IntVariable left, IntVariable right) {
            return left + right;
        }

        public static int operator -(IntVariable left, IntVariable right) {
            return left - right;
        }

        public static int operator *(IntVariable left, IntVariable right) {
            return left * right;
        }

        public static int operator /(IntVariable left, IntVariable right) {
            return left / right;
        }

        public static int operator %(IntVariable left, IntVariable right) {
            return left % right;
        }

        public static IntVariable operator ++(IntVariable left) {
            left.Value++;
            return left;
        }

        public static IntVariable operator --(IntVariable left) {
            left.Value--;
            return left;
        }

        public static bool operator ==(IntVariable x, IntVariable y) {
            if (!x || !y) {
                return (UnityEngine.Object)x == (UnityEngine.Object)y;
            }
            return x.Value == y.Value;
        }

        public static bool operator !=(IntVariable x, IntVariable y) {
            if (!x || !y) {
                return (UnityEngine.Object)x != (UnityEngine.Object)y;
            }
            return x.Value != y.Value;
        }

        public static bool operator ==(FloatVariable x, IntVariable y) {
            if (!x || !y) {
                return (UnityEngine.Object)x == (UnityEngine.Object)y;
            }
            return (int)x.Value == y.Value;
        }

        public static bool operator !=(FloatVariable x, IntVariable y) {
            if (!x || !y) {
                return (UnityEngine.Object)x != (UnityEngine.Object)y;
            }
            return (int)x.Value != y.Value;
        }

        bool IEquatable<DataVariable<float>>.Equals(DataVariable<float> other) {
            if (!other) return false;
            return other.Value == Value;
        }

        bool IEquatable<IntVariable>.Equals(IntVariable other) {
            if (!other) return false;
            return other.Value == Value;
        }

        bool IEquatable<DataVariable<int>>.Equals(DataVariable<int> other) {
            if (!other) return false;
            return other.Value == Value;
        }

        bool IEquatable<FloatVariable>.Equals(FloatVariable other) {
            if (!other) return false;
            return other.Value == Value;
        }
    }
}