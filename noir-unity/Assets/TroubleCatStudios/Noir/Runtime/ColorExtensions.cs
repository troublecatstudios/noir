﻿using System.Collections;
using UnityEngine;

namespace Noir {
    public static class ColorExtensions {
        public static IEnumerator FadeTo(this Color color, Color colorb, float duration) {
            Vector4 delta = new Vector4(color.r - colorb.r, color.g - colorb.g, color.b - colorb.b, color.a - colorb.a);
            var pct = 0 / duration;
            var time = 0f;
            while (pct < 1) {
                time += Time.deltaTime;
                pct = time / duration;
                var v = color.ToVector4() + (delta * pct);
                color = v.ToColor();
                yield return new WaitForEndOfFrame();
            }
        }

        public static Color ToColor(this Vector4 vector) {
            return new Color(vector.x, vector.y, vector.z, vector.w);
        }

        public static Vector4 ToVector4(this Color color) {
            return new Vector4(color.r, color.g, color.b, color.a);
        }

        public static Color WithAlpha(this Color color, float alpha) {
            return new Color(color.r, color.g, color.b, alpha);
        }

        public enum ColorBlendMode {
            Additive,
            Multiply,
            Divide,
            Subtract,
            Darken,
            Lighten,
            Overlay,
        }

        private static float Multiply(float b, float s) {
            return b * s;
        }

        private static float Screen(float b, float s) {
            return b + s - (b * s);
        }

        private static float Overlay(float b, float s) {
            return HardLight(s, b);
        }

        private static float Darken(float b, float s) {
            return Mathf.Min(b, s);
        }

        private static float Lighten(float b, float s) {
            return Mathf.Max(b, s);
        }

        // Color Dodge & Color Burn:  http://wwwimages.adobe.com/www.adobe.com/content/dam/Adobe/en/devnet/pdf/pdfs/adobe_supplement_iso32000_1.pdf
        private static float ColorDodge(float b, float s) {
            if (b == 0)
                return 0;
            else if (b >= (1 - s))
                return 1;
            else
                return b / (1 - s);
        }

        private static float ColorBurn(float b, float s) {
            if (b == 1)
                return 1;
            else if ((1 - b) >= s)
                return 0;
            else
                return 1 - ((1 - b) / s);
        }

        private static float HardLight(float b, float s) {
            if (s <= 0.5)
                return Multiply(b, 2 * s);
            else
                return Screen(b, 2 * s - 1);
        }

        private static float SoftLight(float b, float s) {
            if (s <= 0.5)
                return b - (1 - 2 * s) * b * (1 - b);
            else
                return b + (2 * s - 1) * (SoftLightD(b) - b);
        }

        private static float SoftLightD(float x) {
            if (x <= 0.25)
                return ((16 * x - 12) * x + 4) * x;
            else
                return Mathf.Sqrt(x);
        }

        private static float Difference(float b, float s) {
            return Mathf.Abs(b - s);
        }

        private static float Exclusion(float b, float s) {
            return b + s - 2 * b * s;
        }

        public static Color MinWith(this Color c1, Color c2) {
            var r = Mathf.Min(c1.r, c2.r);
            var g = Mathf.Min(c1.g, c2.g);
            var b = Mathf.Min(c1.b, c2.b);
            var a = Mathf.Min(c1.a, c2.a);
            return new Color(r, g, b, a);
        }

        public static Color MaxWith(this Color c1, Color c2) {
            var r = Mathf.Max(c1.r, c2.r);
            var g = Mathf.Max(c1.g, c2.g);
            var b = Mathf.Max(c1.b, c2.b);
            var a = Mathf.Max(c1.a, c2.a);
            return new Color(r, g, b, a);
        }

        public static Color BlendWith(this Color a, Color b, ColorBlendMode mode = ColorBlendMode.Multiply) {
            var c = new Color();
            switch (mode) {
                case ColorBlendMode.Multiply: c = a * b; break;
                case ColorBlendMode.Additive: c = a + b; break;
                case ColorBlendMode.Darken: return a.Darken(b);
                case ColorBlendMode.Lighten: return a.Lighten(b);
                case ColorBlendMode.Overlay: return a.Overlay(b);
            }
            return c;
        }

        public static Color Lighten(this Color a) {
            return a.Lighten(Color.white.WithAlpha(0.5f));
        }

        public static Color Lighten(this Color a, Color b) {
            Color c = new Color();

            c.r = Lighten(a.r, b.r);
            c.g = Lighten(a.g, b.g);
            c.b = Lighten(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Color Darken(this Color a) {
            return a.Lighten(Color.black.WithAlpha(0.5f));
        }

        public static Color Darken(this Color a, Color b) {
            Color c = new Color();


            c.r = Mathf.Min(a.r, b.r);
            c.g = Mathf.Min(a.g, b.g);
            c.b = Mathf.Min(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Color Overlay(this Color a, Color b) {
            Color c = new Color();


            if (a.r < 0.5)
                c.r = 2f * a.r * b.r;
            else
                c.r = 1f - 2f * (1f - b.r) * (1f - a.r);

            if (a.g < 0.5)
                c.g = 2f * a.g * b.g;
            else
                c.g = 1f - 2f * (1f - b.g) * (1f - a.g);

            if (a.b < 0.5)
                c.b = 2f * a.b * b.b;
            else
                c.b = 1f - 2f * (1f - b.b) * (1f - a.b);

            c = ((1f - b.a) * a) + (b.a * c);

            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Color HardLight(this Color a, Color b) {
            Color c = new Color();

            c.r = HardLight(a.r, b.r);
            c.g = HardLight(a.g, b.g);
            c.b = HardLight(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Color SoftLight(this Color a, Color b) {
            Color c = new Color();

            c.r = SoftLight(a.r, b.r);
            c.g = SoftLight(a.g, b.g);
            c.b = SoftLight(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Color Difference(this Color a, Color b) {
            Color c = new Color();

            c.r = Difference(a.r, b.r);
            c.g = Difference(a.g, b.g);
            c.b = Difference(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Color Exclusion(this Color a, Color b) {
            Color c = new Color();

            c.r = Exclusion(a.r, b.r);
            c.g = Exclusion(a.g, b.g);
            c.b = Exclusion(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        public static Vector3 ToVector3(this Color c) {
            return (Vector3)c.ToVector4();
        }

        public static Vector2 XY(this Color c) {
            return new Vector2(c.r, c.g);
        }
        public static Vector2 XZ(this Color c) {
            return new Vector2(c.r, c.b);
        }

        public static Vector2 XW(this Color c) {
            return new Vector2(c.r, c.a);
        }

        public static Vector2 YX(this Color c) {
            return new Vector2(c.g, c.r);
        }

        public static Vector2 YZ(this Color c) {
            return new Vector2(c.g, c.b);
        }

        public static Vector2 YW(this Color c) {
            return new Vector2(c.g, c.a);
        }

        public static Vector2 ZX(this Color c) {
            return new Vector2(c.b, c.r);
        }

        public static Vector2 ZY(this Color c) {
            return new Vector2(c.b, c.g);
        }

        public static Vector2 ZW(this Color c) {
            return new Vector2(c.b, c.a);
        }

        public static Vector2 XX(this Color c) {
            return new Vector2(c.r, c.r);
        }

        public static Vector3 XXX(this Color c) {
            return new Vector3(c.r, c.r, c.r);
        }

        public static Vector4 XXXX(this Color c) {
            return new Vector4(c.r, c.r, c.r, c.r);
        }

        public static Vector2 YY(this Color c) {
            return new Vector2(c.g, c.g);
        }

        public static Vector3 YYY(this Color c) {
            return new Vector3(c.g, c.g, c.g);
        }

        public static Vector4 YYYY(this Color c) {
            return new Vector4(c.g, c.g, c.g, c.g);
        }

        public static Vector2 ZZ(this Color c) {
            return new Vector2(c.b, c.b);
        }

        public static Vector3 ZZZ(this Color c) {
            return new Vector3(c.b, c.b, c.b);
        }

        public static Vector4 ZZZZ(this Color c) {
            return new Vector4(c.b, c.b, c.b, c.b);
        }

        public static Vector3 XYZ(this Color c) {
            return c.ToVector3();
        }
    }
}