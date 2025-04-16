using UnityEngine;

namespace Noir.Randomness {
    public struct PoissonSettings {
        public Vector2 BottomLeft;
        public Vector2 TopRight;
        public Vector2 Center;
        public Vector2? StartingPoint;
        public Rect Dimension;

        public int RandomSeed;

        public float MinimumDistance;
        public int IterationsPerPoint;

        public float CellSize;
        public int GridWidth;
        public int GridHeight;
    }
}