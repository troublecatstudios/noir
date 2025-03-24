﻿using System;
using UnityEngine;

namespace Noir {
    public static class VectorExtensions {
        public static string ToLogString(this Vector2 vector) {
            return $"(x={vector.x}, y={vector.y})";
        }

        public static string ToLogString(this Vector3 vector) {
            return $"(x={vector.x}, y={vector.y}, z={vector.z})";
        }

        public static string ToLogString(this Vector2Int vector) {
            return $"(x={vector.x}, y={vector.y})";
        }

        public static string ToLogString(this Vector3Int vector) {
            return $"(x={vector.x}, y={vector.y}, z={vector.z})";
        }

        public static Vector3 Abs(this Vector3 vector) {
            return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        public static Vector2 Abs(this Vector2 vector) {
            return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        public static Vector2 Sign(this Vector2 vector, bool ignoreZeros = false) {
            var x = ignoreZeros && vector.x == 0 ? 0 : Mathf.Sign(vector.x);
            var y = ignoreZeros && vector.y == 0 ? 0 : Mathf.Sign(vector.y);
            return new Vector2(x, y);
        }

        public static Vector3 Sign(this Vector3 vector, bool ignoreZeros = false) {
            var x = ignoreZeros && vector.x == 0 ? 0 : Mathf.Sign(vector.x);
            var y = ignoreZeros && vector.y == 0 ? 0 : Mathf.Sign(vector.y);
            var z = ignoreZeros && vector.z == 0 ? 0 : Mathf.Sign(vector.z);
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Returns the direction vector between this Vector2 and another.
        /// </summary>
        /// <param name="vector">The origin vector.</param>
        /// <param name="other">The destination vector.</param>
        /// <param name="normalize">if set to <c>true</c> the result will be normalized.</param>
        /// <returns>A vector representing the direction from the origin vector to the destination vector.</returns>
        public static Vector2 DirectionTo(this Vector2 vector, Vector2 other, bool normalize = true) {
            var direction = other - vector;
            if (normalize) return direction.normalized;
            return direction;
        }

        /// <summary>
        /// Returns the direction vector between this Vector3 and another.
        /// </summary>
        /// <param name="vector">The origin vector.</param>
        /// <param name="other">The destination vector.</param>
        /// <param name="normalize">if set to <c>true</c> the result will be normalized.</param>
        /// <returns>A vector representing the direction from the origin vector to the destination vector.</returns>
        public static Vector3 DirectionTo(this Vector3 vector, Vector3 other, bool normalize = true) {
            var direction = other - vector;
            if (normalize) return direction.normalized;
            return direction;
        }
    }
}