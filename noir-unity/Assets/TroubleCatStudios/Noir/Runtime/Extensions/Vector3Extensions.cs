using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Noir.Unity.Extensions {
    public static class Vector3Extensions {
        public static Vector3 InvertY(this Vector3 vector) {
            return new Vector3(vector.x, vector.y * -1, vector.z);
        }
        public static Vector3 InvertX(this Vector3 vector) {
            return new Vector3(vector.x * -1, vector.y, vector.z);
        }
        public static Vector3 InvertZ(this Vector3 vector) {
            return new Vector3(vector.x, vector.y, vector.z * -1);
        }
    }
}
