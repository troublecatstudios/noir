using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Noir {
    [Serializable]
    public struct Vector4Int : IEquatable<Vector4Int> {

        public static readonly Vector4Int zero = new(0, 0, 0, 0);
        public static readonly Vector4Int up = new(0, 1, 0, 0);
        public static readonly Vector4Int right = new(1, 0, 0, 0);
        public static readonly Vector4Int down = new(0, -1, 0, 0);
        public static readonly Vector4Int left = new(-1, 0, 0, 0);

        public Vector4Int(int x, int y, int z, int w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public int x;
        public int y;
        public int z;
        public int w;

        public int sqrMagnitude
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return x * x + y * y + z * z + w * w;
            }
        }

        public static implicit operator Vector4Int(Vector3Int vector) => new(vector.x, vector.y, vector.z, 0);
        public static explicit operator (Vector3 vector, int SceneId)(Vector4Int vector) => (new Vector3(vector.x, vector.y, vector.z), vector.w);
        public static explicit operator (Vector2Int vector, int AreaId)(Vector4Int vector) => (new Vector2Int(vector.x, vector.y), vector.w);
        public static implicit operator Vector4Int((Vector3Int Vector, int AreaId) tuple) => new(tuple.Vector.x, tuple.Vector.y, tuple.Vector.z, tuple.AreaId);
        public static implicit operator Vector3(Vector4Int vector) => new(vector.x, vector.y, vector.z);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Vector4Int lhs, Vector4Int rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Vector4Int lhs, Vector4Int rhs)
        {
            return !(lhs == rhs);
        }

        public static Vector4Int operator +(Vector4Int lhs, Vector4Int rhs) {
            return new Vector4Int(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static Vector4Int operator -(Vector4Int lhs, Vector4Int rhs) {
            return new Vector4Int(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        public static Vector4Int operator *(Vector4Int lhs, int multi) {
            return new Vector4Int(lhs.x * multi, lhs.y * multi, lhs.z * multi, lhs.w * multi);
        }

        public override string ToString() {
            return $"(x={x}, y={y}, z={z}, w={w})";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj) {
            if (obj is Vector4Int vector) {
                return Equals(vector);
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return HashCode.Combine(x.GetHashCode(), y.GetHashCode(), z.GetHashCode(), w.GetHashCode());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Vector4Int other) {
            return this == other;
        }
    }
}