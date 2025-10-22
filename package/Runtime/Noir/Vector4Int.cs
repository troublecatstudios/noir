// ReSharper disable InconsistentNaming

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Represents a four-dimensional vector with integer components.
    /// Provides basic arithmetic operations, conversions, and equality comparisons.
    /// </summary>
    [Serializable]
    public struct Vector4Int : IEquatable<Vector4Int> {

        /// <summary>
        /// A read-only <see cref="Vector4Int"/> with all components set to zero.
        /// </summary>
        public static readonly Vector4Int zero = new(0, 0, 0, 0);

        /// <summary>
        /// A read-only <see cref="Vector4Int"/> pointing up (0, 1, 0, 0).
        /// </summary>
        public static readonly Vector4Int up = new(0, 1, 0, 0);

        /// <summary>
        /// A read-only <see cref="Vector4Int"/> pointing right (1, 0, 0, 0).
        /// </summary>
        public static readonly Vector4Int right = new(1, 0, 0, 0);

        /// <summary>
        /// A read-only <see cref="Vector4Int"/> pointing down (0, -1, 0, 0).
        /// </summary>
        public static readonly Vector4Int down = new(0, -1, 0, 0);

        /// <summary>
        /// A read-only <see cref="Vector4Int"/> pointing left (-1, 0, 0, 0).
        /// </summary>
        public static readonly Vector4Int left = new(-1, 0, 0, 0);

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4Int"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public Vector4Int(int x, int y, int z, int w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// The X component of the vector.
        /// </summary>
        public int x;

        /// <summary>
        /// The Y component of the vector.
        /// </summary>
        public int y;

        /// <summary>
        /// The Z component of the vector.
        /// </summary>
        public int z;

        /// <summary>
        /// The W component of the vector.
        /// </summary>
        public int w;

        /// <summary>
        /// Gets the squared magnitude of the vector.
        /// </summary>
        public int sqrMagnitude
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return x * x + y * y + z * z + w * w;
            }
        }

        /// <summary>
        /// Implicitly converts a <see cref="Vector3Int"/> to a <see cref="Vector4Int"/>, setting <c>w</c> to 0.
        /// </summary>
        public static implicit operator Vector4Int(Vector3Int vector) => new(vector.x, vector.y, vector.z, 0);

        /// <summary>
        /// Explicitly converts a <see cref="Vector4Int"/> to a tuple containing a <see cref="Vector3"/> and an integer (SceneId).
        /// </summary>
        public static explicit operator (Vector3 vector, int SceneId)(Vector4Int vector) => (new Vector3(vector.x, vector.y, vector.z), vector.w);

        /// <summary>
        /// Explicitly converts a <see cref="Vector4Int"/> to a tuple containing a <see cref="Vector2Int"/> and an integer (AreaId).
        /// </summary>
        public static explicit operator (Vector2Int vector, int AreaId)(Vector4Int vector) => (new Vector2Int(vector.x, vector.y), vector.w);

        /// <summary>
        /// Implicitly converts a tuple of a <see cref="Vector3Int"/> and an integer (AreaId) to a <see cref="Vector4Int"/>.
        /// </summary>
        public static implicit operator Vector4Int((Vector3Int Vector, int AreaId) tuple) => new(tuple.Vector.x, tuple.Vector.y, tuple.Vector.z, tuple.AreaId);

        /// <summary>
        /// Implicitly converts a <see cref="Vector4Int"/> to a <see cref="Vector3"/>, discarding the <c>w</c> component.
        /// </summary>
        public static implicit operator Vector3(Vector4Int vector) => new(vector.x, vector.y, vector.z);


        /// <summary>
        /// Determines whether two <see cref="Vector4Int"/> instances are equal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4Int lhs, Vector4Int rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w;
        }

        /// <summary>
        /// Determines whether two <see cref="Vector4Int"/> instances are not equal.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4Int lhs, Vector4Int rhs)
        {
            return !(lhs == rhs);
        }

        /// <summary>
        /// Adds two <see cref="Vector4Int"/> instances component-wise.
        /// </summary>
        public static Vector4Int operator +(Vector4Int lhs, Vector4Int rhs) {
            return new Vector4Int(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        /// <summary>
        /// Subtracts one <see cref="Vector4Int"/> from another component-wise.
        /// </summary>
        public static Vector4Int operator -(Vector4Int lhs, Vector4Int rhs) {
            return new Vector4Int(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        /// <summary>
        /// Multiplies a <see cref="Vector4Int"/> by an integer scalar.
        /// </summary>
        public static Vector4Int operator *(Vector4Int lhs, int multi) {
            return new Vector4Int(lhs.x * multi, lhs.y * multi, lhs.z * multi, lhs.w * multi);
        }

        /// <summary>
        /// Returns a string representation of the vector in the format "(x=..., y=..., z=..., w=...)".
        /// </summary>
        public override string ToString() {
            return $"(x={x}, y={y}, z={z}, w={w})";
        }

        /// <summary>
        /// Determines whether this instance is equal to another object.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><c>true</c> if the object is a <see cref="Vector4Int"/> with the same component values; otherwise, <c>false</c>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) {
            if (obj is Vector4Int vector) {
                return Equals(vector);
            }
            return false;
        }

        /// <summary>
        /// Returns a hash code for the current <see cref="Vector4Int"/> instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code computed from the four components of the vector.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return HashCode.Combine(x.GetHashCode(), y.GetHashCode(), z.GetHashCode(), w.GetHashCode());
        }

        /// <summary>
        /// Determines whether this vector is equal to another <see cref="Vector4Int"/>.
        /// </summary>
        /// <param name="other">The other vector to compare with.</param>
        /// <returns><c>true</c> if the vectors are equal; otherwise, <c>false</c>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int other) {
            return this == other;
        }
    }
}