﻿using System;
 using System.Runtime.CompilerServices;
 using UnityEngine;

namespace Noir {
    /// <summary>
    /// Extension methods for Unity Vector types.
    /// </summary>
    public static class VectorExtensions {
        /// <summary>
        /// Returns a formatted string representing the components of a <see cref="Vector2"/>.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to format.</param>
        /// <returns>A string in the format "(x=..., y=...)".</returns>
        public static string ToLogString(this Vector2 vector) {
            return $"(x={vector.x}, y={vector.y})";
        }

        /// <summary>
        /// Returns a formatted string representing the components of a <see cref="Vector3"/>.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to format.</param>
        /// <returns>A string in the format "(x=..., y=..., z=...)".</returns>
        public static string ToLogString(this Vector3 vector) {
            return $"(x={vector.x}, y={vector.y}, z={vector.z})";
        }

        /// <summary>
        /// Returns a formatted string representing the components of a <see cref="Vector2Int"/>.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2Int"/> to format.</param>
        /// <returns>A string in the format "(x=..., y=...)".</returns>
        public static string ToLogString(this Vector2Int vector) {
            return $"(x={vector.x}, y={vector.y})";
        }

        /// <summary>
        /// Returns a formatted string representing the components of a <see cref="Vector3Int"/>.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3Int"/> to format.</param>
        /// <returns>A string in the format "(x=..., y=..., z=...)".</returns>
        public static string ToLogString(this Vector3Int vector) {
            return $"(x={vector.x}, y={vector.y}, z={vector.z})";
        }

        /// <summary>
        /// Returns a new <see cref="Vector3"/> with each component replaced by its absolute value.
        /// </summary>
        /// <param name="vector">The <see cref="Vector3"/> to process.</param>
        /// <returns>A new <see cref="Vector3"/> where each component is the absolute value of the original.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Abs(this Vector3 vector) {
            return new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
        }

        /// <summary>
        /// Returns a new <see cref="Vector2"/> with each component replaced by its absolute value.
        /// </summary>
        /// <param name="vector">The <see cref="Vector2"/> to process.</param>
        /// <returns>A new <see cref="Vector2"/> where each component is the absolute value of the original.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Abs(this Vector2 vector) {
            return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        /// <summary>
        /// Returns a new <see cref="Vector2"/> with each component replaced by its sign (-1, 0, or 1).
        /// </summary>
        /// <param name="vector">The input vector.</param>
        /// <param name="ignoreZeros">
        /// If true, components equal to zero remain zero instead of being converted by <see cref="Mathf.Sign"/>.
        /// </param>
        /// <returns>
        /// A new <see cref="Vector2"/> where each component represents the sign of the corresponding component in <paramref name="vector"/>.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sign(this Vector2 vector, bool ignoreZeros = false) {
            var x = ignoreZeros && vector.x == 0 ? 0 : Mathf.Sign(vector.x);
            var y = ignoreZeros && vector.y == 0 ? 0 : Mathf.Sign(vector.y);
            return new Vector2(x, y);
        }

        /// <summary>
        /// Returns a new <see cref="Vector3"/> with each component replaced by its sign (-1, 0, or 1).
        /// </summary>
        /// <param name="vector">The input vector.</param>
        /// <param name="ignoreZeros">
        /// If true, components equal to zero remain zero instead of being converted by <see cref="Mathf.Sign"/>.
        /// </param>
        /// <returns>
        /// A new <see cref="Vector3"/> where each component represents the sign of the corresponding component in <paramref name="vector"/>.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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