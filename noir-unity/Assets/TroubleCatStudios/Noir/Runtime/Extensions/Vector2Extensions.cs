using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Noir.Unity.Extensions {
    public static class Vector2Extensions {
        public static Vector2 InvertY(this Vector2 vector) {
            return new Vector2(vector.x, vector.y * -1);
        }
        public static Vector2 InvertX(this Vector2 vector) {
            return new Vector2(vector.x * -1, vector.y);
        }
    }
}
