using System;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Represents a value along the X-Axis.
    /// </summary>
    [Serializable]
    public enum HorizontalDirections : int {
        Right = 1,
        None = 0,
        Left = -1,
    }

    /// <summary>
    /// Represents a value along the Y-Axis.
    /// </summary>
    [Serializable]
    public enum VerticalDirections : int {
        Up = 1,
        None = 0,
        Down = -1,
    }

    /// <summary>
    /// Represents a value along the Z-axis
    /// </summary>
    [Serializable]
    public enum PerpendicularDirections : int {
        Forward = 1,
        None = 0,
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

        public bool Equals(Direction other) {
            return other.Horizontal == Horizontal && other.Vertical == Vertical && other.Perpendicular == Perpendicular;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Horizontal, Vertical, Perpendicular);
        }

        public override bool Equals(object obj) {
            if (obj is Direction d) {
                return Equals(d);
            }
            return base.Equals(obj);
        }

        public static implicit operator Vector2(Direction d) => new Vector2((int)d.Horizontal, (int)d.Vertical);
        public static explicit operator Direction(Vector2 v) => new Direction(v);

        public static implicit operator Vector3(Direction d) => new Vector3((int)d.Horizontal, (int)d.Vertical, (int)d.Perpendicular);
        public static explicit operator Direction(Vector3 v) => new Direction(v);

        public static bool operator ==(Direction a, Direction b) => a.Equals(b);
        public static bool operator !=(Direction a, Direction b) => !a.Equals(b);
    }
}