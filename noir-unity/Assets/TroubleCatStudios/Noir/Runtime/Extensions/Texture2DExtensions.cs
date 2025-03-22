using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Noir.Unity.Extensions {
    public static class Texture2DExtensions {
        public static Vector2 GetSize(this Texture2D texture) {
            return new Vector2(texture.width, texture.height);
        }
    }
}
