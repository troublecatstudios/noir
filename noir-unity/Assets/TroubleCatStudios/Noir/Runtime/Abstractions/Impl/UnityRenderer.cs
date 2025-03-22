using UnityEngine;
using UnityEngine.Tilemaps;

namespace Noir.Unity.Abstractions.Impl {
    public class UnityRenderer : AbstractRenderer {

        private Component _renderer;

        public UnityRenderer(SpriteRenderer spriteRenderer) {
            _renderer = spriteRenderer;
        }

        public UnityRenderer(Tilemap tilemap) {
            _renderer = tilemap;
        }

        public override Color color {
            get {
                if (_renderer is SpriteRenderer spriteRenderer) {
                    return spriteRenderer.color;
                }
                if (_renderer is Tilemap tilemap) {
                    return tilemap.color;
                }
                return Color.white;
            }
            set {
                if (_renderer is SpriteRenderer spriteRenderer) {
                    spriteRenderer.color = value;
                }
                if (_renderer is Tilemap tilemap) {
                    tilemap.color = value;
                }
            }
        }

        public override void GetPropertyBlock(MaterialPropertyBlock properties) {
            if (_renderer is Renderer renderer) {
                renderer.GetPropertyBlock(properties);
            }
        }

        public override void SetPropertyBlock(MaterialPropertyBlock properties) {
            if (_renderer is Renderer renderer) {
                renderer.SetPropertyBlock(properties);
            }
        }
    }
}
