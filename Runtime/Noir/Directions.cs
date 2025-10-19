using System;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Represents a value along the X-Axis.
    /// </summary>
    [Serializable]
    public enum HorizontalDirections : int {
        /// <summary>
        /// Right direction along the X-axis.
        /// </summary>
        Right = 1,
        /// <summary>
        /// No direction along the X-axis.
        /// </summary>
        None = 0,
        /// <summary>
        /// Left direction along the X-axis.
        /// </summary>
        Left = -1,
    }

    /// <summary>
    /// Represents a value along the Y-Axis.
    /// </summary>
    [Serializable]
    public enum VerticalDirections : int {
        /// <summary>
        /// Up direction along the Y-axis.
        /// </summary>
        Up = 1,
        /// <summary>
        /// No direction along the Y-axis.
        /// </summary>
        None = 0,
        /// <summary>
        /// Down direction along the Y-axis.
        /// </summary>
        Down = -1,
    }

    /// <summary>
    /// Represents a value along the Z-axis
    /// </summary>
    [Serializable]
    public enum PerpendicularDirections : int {
        /// <summary>
        /// Forward direction along the Z-axis.
        /// </summary>
        Forward = 1,
        /// <summary>
        /// No direction along the Z-axis.
        /// </summary>
        None = 0,
        /// <summary>
        /// Backward direction along the Z-axis.
        /// </summary>
        Backward = -1,
    }

    /// <summary>
    /// Represents a direction in two-dimensional or three-dimensional space. The horizontal and vertical axis are
    /// separated out into easier to read properties <see cref="Horizontal"/> and <see cref="Vertical"/> respectively.
    /// </summary>
    /// <remarks>
    /// Can be implicitly cast to a <see cref="Vector2"/>.
    /// </remarks>
    [Serializable]
    public struct Direction : IEquatable<Direction> {
        public static readonly Direction None = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Direction"/> struct.
        /// </summary>
        /// <param name="vector">The vector.</param>
        public Direction(Vector2 vector) {
            var x = vector.x;
            var absX = Mathf.Abs(x);
            Horizontal = (HorizontalDirections)(int)Mathf.Sign(x);
            if (Mathf.Approximately(x, 0f) || absX - 0.1f == 0f) {
                Horizontal = HorizontalDirections.None;
            }

            var y = vector.y;
            var absY = Mathf.Abs(y);
            Vertical = (VerticalDirections)(int)Mathf.Sign(y);
            if (0 == (int)Mathf.FloorToInt(absY) && 0 == (int)Mathf.RoundToInt(absY)) {
                Vertical = VerticalDirections.None;
            }

            Perpendicular = PerpendicularDirections.None;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Direction"/> struct.
        /// </summary>
        /// <param name="vector">The vector.</param>
        public Direction(Vector3 vector) : this(new Vector2(vector.x, vector.y)) {
            var z = vector.z;
            var absZ = Mathf.Abs(z);
            Perpendicular = (PerpendicularDirections)(int)Mathf.Sign(z);
            if (0 == (int)Mathf.FloorToInt(absZ) && 0 == (int)Mathf.RoundToInt(absZ)) {
                Perpendicular = PerpendicularDirections.None;
            }
        }

        /// <summary>
        /// Gets the horizontal axis.
        /// </summary>
        /// <value>
        /// The horizontal axis.
        /// </value>
        public HorizontalDirections Horizontal { get; private set; }

        /// <summary>
        /// Gets the vertical axis.
        /// </summary>
        /// <value>
        /// The vertical axis.
        /// </value>
        public VerticalDirections Vertical { get; private set; }

        /// <summary>
        /// Gets the perpendicular axis.
        /// </summary>
        /// <value>
        /// The perpendicular axis.
        /// </value>
        public PerpendicularDirections Perpendicular { get; private set; }

        /// <summary>
        /// Determines whether this instance and another <see cref="Direction"/> are equal.
        /// </summary>
        /// <param name="other">The other direction to compare.</param>
        /// <returns><c>true</c> if the directions are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(Direction other) {
            return other.Horizontal == Horizontal && other.Vertical == Vertical && other.Perpendicular == Perpendicular;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode() {
            return HashCode.Combine(Horizontal, Vertical, Perpendicular);
        }

        /// <summary>
        /// Determines whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with this direction.</param>
        /// <returns><c>true</c> if the object is a <see cref="Direction"/> and is equal; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj) {
            if (obj is Direction d) {
                return Equals(d);
            }
            return base.Equals(obj);
        }

        /// <summary>
        /// Converts a <see cref="Direction"/> to a <see cref="Vector2"/>.
        /// </summary>
        /// <param name="d">The direction to convert.</param>
        public static implicit operator Vector2(Direction d) => new Vector2((int)d.Horizontal, (int)d.Vertical);

        /// <summary>
        /// Converts a <see cref="Vector2"/> to a <see cref="Direction"/>.
        /// </summary>
        /// <param name="v">The vector to convert.</param>
        public static explicit operator Direction(Vector2 v) => new Direction(v);

        /// <summary>
        /// Converts a <see cref="Direction"/> to a <see cref="Vector3"/>.
        /// </summary>
        /// <param name="d">The direction to convert.</param>
        public static implicit operator Vector3(Direction d) => new Vector3((int)d.Horizontal, (int)d.Vertical, (int)d.Perpendicular);

        /// <summary>
        /// Converts a <see cref="Vector3"/> to a <see cref="Direction"/>.
        /// </summary>
        /// <param name="v">The vector to convert.</param>
        public static explicit operator Direction(Vector3 v) => new Direction(v);

        /// <summary>
        /// Determines whether two <see cref="Direction"/> instances are equal.
        /// </summary>
        /// <param name="a">The first direction.</param>
        /// <param name="b">The second direction.</param>
        /// <returns><c>true</c> if the directions are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Direction a, Direction b) => a.Equals(b);

        /// <summary>
        /// Determines whether two <see cref="Direction"/> instances are not equal.
        /// </summary>
        /// <param name="a">The first direction.</param>
        /// <param name="b">The second direction.</param>
        /// <returns><c>true</c> if the directions are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(Direction a, Direction b) => !a.Equals(b);
    }
}