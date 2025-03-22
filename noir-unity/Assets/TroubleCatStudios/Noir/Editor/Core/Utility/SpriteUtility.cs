using UnityEngine;

namespace NoirUnityEditor.Utility {
    public static class SpriteUtility {
        public static Texture2D ConvertToTexture2D(Sprite sprite) {
            var pixels = sprite.texture.GetPixels((int)sprite.textureRect.x,
                                                (int)sprite.textureRect.y,
                                                (int)sprite.textureRect.width,
                                                (int)sprite.textureRect.height);

            Texture2D textura = new Texture2D((int)sprite.textureRect.width,
                                                (int)sprite.textureRect.height);

            textura.SetPixels(pixels);
            textura.Apply();
            return textura;
        }

        public static Color[] GetPixels(Sprite sprite) {
            var pixels = sprite.texture.GetPixels((int)sprite.textureRect.x,
                                                (int)sprite.textureRect.y,
                                                (int)sprite.textureRect.width,
                                                (int)sprite.textureRect.height);
            return pixels;
        }

        public static Color32[] GetPixles32(Sprite sprite) {
            var width = Mathf.RoundToInt(sprite.textureRect.width);
            var height = Mathf.RoundToInt(sprite.textureRect.height);
            var xOffset = Mathf.RoundToInt(sprite.textureRect.x);
            var yOffset = Mathf.RoundToInt(sprite.textureRect.y);
            var pixels = new Color32[width * height];
            var rawPixels = sprite.texture.GetPixels32();
            int idx = 0;
            for (var x = xOffset; x < (xOffset + width); x++) {
                for (var y = yOffset; y < (yOffset + height); y++) {
                    pixels[idx++] = rawPixels[y * height + x];
                }
            }
            return pixels;
        }
    }
}
