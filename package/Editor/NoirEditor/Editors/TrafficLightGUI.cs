using Noir.Attributes;
using UnityEditor;
using UnityEngine;

namespace NoirEditor.Editors {
    internal enum TrafficLightSize {
        Single,
        Double,
        Triple,
        Quad
    }

    internal static class TrafficLightGUI {
        private static Texture[] lightArray;
        private static Texture[] frameArray;

        public static Vector2 SingleLightSize { get { return new Vector2(20, 20); } }
        public static Vector2 DoubleLightSize { get { return new Vector2(39, 20); } }
        public static Vector2 TripleLightSize { get { return new Vector2(56, 20); } }
        public static Vector2 QuadLightSize { get { return new Vector2(79, 20); } }

        private static string AssetPath = "Assets/TroubleCatStudios/Noir/Resources/Textures/TrafficLights/";

        private static Texture GetLightTexture(TrafficLightColor tex) {
            // get the light texture for a specified colour
            // if the texture has not yet been loaded find it
            if (lightArray == null) {
                lightArray = new Texture[7];
            }

            if (lightArray[(int)tex] == null) {
                // NOTE if you put the texturea in a different folder please update this
                lightArray[(int)tex] = AssetDatabase.LoadAssetAtPath<Texture>(AssetPath + "light" + System.Enum.GetName(typeof(TrafficLightColor), tex) + ".png");
            }

            return lightArray[(int)tex];
        }

        private static Texture GetTrafficLightFrameTexture(TrafficLightSize tex) {
            // get the light frame texture for a specified colour
            // if the texture has not yet been loaded find it

            if (frameArray == null) {
                frameArray = new Texture[4];
            }

            if (frameArray[(int)tex] == null) {
                // NOTE if you put the texturea in a different folder please update this
                frameArray[(int)tex] = AssetDatabase.LoadAssetAtPath<Texture>(AssetPath + "tlFrame" + System.Enum.GetName(typeof(TrafficLightSize), tex) + ".png");
            }

            return frameArray[(int)tex];
        }

        // Draws a single light texture
        private static void DrawLight(Rect position, TrafficLightColor type) {
            GUI.Label(position, GetLightTexture(type), GUIStyle.none);
        }

        // These methods draw the Traffic Light in a given rectangle.
        // Reccomend you use the layout versions, as then you dont
        // have to worry about getting the sizes right!!
        public static void DrawTrafficLightSingle(Rect position, TrafficLightColor type) {
            // Draw the frame
            GUI.Label(position, GetTrafficLightFrameTexture(TrafficLightSize.Single), GUIStyle.none);

            // offset position and draw the light
            position.position += new Vector2(2, 2);
            position.size = new Vector2(16, 16);
            DrawLight(position, type);
        }

        public static void DrawTrafficLightDouble(Rect position, TrafficLightColor typeA, TrafficLightColor typeB) {
            GUI.Label(position, GetTrafficLightFrameTexture(TrafficLightSize.Double), GUIStyle.none);

            position.position += new Vector2(3, 2);
            position.size = new Vector2(16, 16);
            DrawLight(position, typeA);

            position.position += new Vector2(16 + 1, 0);
            DrawLight(position, typeB);
        }

        public static void DrawTrafficLightTriple(Rect position, TrafficLightColor typeA, TrafficLightColor typeB, TrafficLightColor typeC) {
            GUI.Label(position, GetTrafficLightFrameTexture(TrafficLightSize.Triple), GUIStyle.none);

            position.position += new Vector2(3, 2);
            position.size = new Vector2(16, 16);
            DrawLight(position, typeA);

            position.position += new Vector2(16 + 1, 0);
            DrawLight(position, typeB);

            position.position += new Vector2(16 + 1, 0);
            DrawLight(position, typeC);
        }

        public static void DrawTrafficLightQuad(Rect position, TrafficLightColor typeA, TrafficLightColor typeB, TrafficLightColor typeC, TrafficLightColor typeD) {
            GUI.Label(position, GetTrafficLightFrameTexture(TrafficLightSize.Quad), GUIStyle.none);

            position.position += new Vector2(3, 2);
            position.size = new Vector2(16, 16);
            DrawLight(position, typeA);

            position.position += new Vector2(16 + 1, 0);
            DrawLight(position, typeB);

            position.position += new Vector2(16 + 1, 0);
            DrawLight(position, typeC);

            position.position += new Vector2(16 + 1, 0);
            DrawLight(position, typeD);
        }

        public static Vector2 GetTrafficLightSize(TrafficLightSize size) {
            // Helper method for getting the light frame texture sizes.
            var frame = GetTrafficLightFrameTexture(size);
            return new Vector2(frame.width, frame.height);
        }
    }
}