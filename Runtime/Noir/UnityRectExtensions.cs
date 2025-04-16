using UnityEngine;

namespace Noir {
    public static class UnityRectExtensions {
        public static Vector2 GetRandomPositionInside(this Rect rect) {
            float randomPosX = Random.Range(rect.position.x - rect.size.x / 2, rect.position.x + rect.size.x / 2);
            float randomPosY = Random.Range(rect.position.y - rect.size.y / 2, rect.position.y + rect.size.y / 2);

            return new Vector2(randomPosX, randomPosY);
        }

        public static Vector2 GetRandomPositionInside(this Rect rect, Vector2 padding) {
            var size = new Vector2(rect.size.x - padding.x, rect.size.y - padding.y);
            float randomPosX = Random.Range(rect.position.x - size.x / 2, rect.position.x + size.x / 2);
            float randomPosY = Random.Range(rect.position.y - size.y / 2, rect.position.y + size.y / 2);

            return new Vector2(randomPosX, randomPosY);
        }

        public static Vector2 TopLeft(this Rect rect) {
            return new Vector2(rect.xMin, rect.yMax);
        }
    }
}