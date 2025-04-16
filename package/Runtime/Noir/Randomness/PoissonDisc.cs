using UnityEngine;

namespace Noir.Randomness {
    public class PoissonDisc {
        public const float InvertRootTwo = 0.70710678118f; // Because two dimension grid.
        public const int DefaultIterationPerPoint = 30;

        public static PoissonSettings CreateSettings(Vector2 bottomLeft, Vector2 topRight, float min, Vector2? startingPoint = null, int seed = 1024, int iterations = DefaultIterationPerPoint) {
            var dimension = (topRight - bottomLeft);
            var cell = min * InvertRootTwo;
            return new PoissonSettings() {
                BottomLeft = bottomLeft,
                TopRight = topRight,
                RandomSeed = seed,
                StartingPoint = startingPoint,
                Center = (bottomLeft + topRight) * 0.5f,
                Dimension = new Rect(new Vector2(bottomLeft.x, bottomLeft.y), new Vector2(dimension.x, dimension.y)),

                MinimumDistance = min,
                IterationsPerPoint = iterations,

                CellSize = cell,
                GridWidth = Mathf.CeilToInt(dimension.x / cell),
                GridHeight = Mathf.CeilToInt(dimension.y / cell)
            };
        }

        public static Vector2Int GetGridIndex(Vector2 point, PoissonSettings set) {
            return new Vector2Int(
                Mathf.FloorToInt((point.x - set.BottomLeft.x) / set.CellSize),
                Mathf.FloorToInt((point.y - set.BottomLeft.y) / set.CellSize)
            );
        }
    }
}