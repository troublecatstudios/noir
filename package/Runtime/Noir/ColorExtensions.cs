﻿using System.Collections;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Extension methods for the <see cref="Color"/> type, including blending, vector conversion, and utility operations.
    /// </summary>
    public static class ColorExtensions {
        /// <summary>
        /// Fades a color to another color over the specified duration, yielding after each frame.
        /// </summary>
        /// <param name="color">The starting color.</param>
        /// <param name="colorb">The color to fade to.</param>
        /// <param name="duration">Duration of the fade in seconds.</param>
        /// <returns>An enumerator for coroutine-based fading.</returns>
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

        /// <summary>
        /// Converts a <see cref="Vector4"/> to a <see cref="Color"/>.
        /// </summary>
        /// <param name="vector">The vector to convert.</param>
        /// <returns>The corresponding <see cref="Color"/>.</returns>
        public static Color ToColor(this Vector4 vector) {
            return new Color(vector.x, vector.y, vector.z, vector.w);
        }

        /// <summary>
        /// Converts a <see cref="Color"/> to a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The corresponding <see cref="Vector4"/>.</returns>
        public static Vector4 ToVector4(this Color color) {
            return new Vector4(color.r, color.g, color.b, color.a);
        }

        /// <summary>
        /// Returns a new color with the alpha channel set to the specified value.
        /// </summary>
        /// <param name="color">The original color.</param>
        /// <param name="alpha">Alpha value to set.</param>
        /// <returns>A new color with updated alpha.</returns>
        public static Color WithAlpha(this Color color, float alpha) {
            return new Color(color.r, color.g, color.b, alpha);
        }

        /// <summary>
        /// Specifies blend modes for color blending operations.
        /// </summary>
        public enum ColorBlendMode {
            /// <summary>
            /// Adds the colors together.
            /// </summary>
            Additive,
            /// <summary>
            /// Multiplies the colors together.
            /// </summary>
            Multiply,
            /// <summary>
            /// Divides the colors.
            /// </summary>
            Divide,
            /// <summary>
            /// Subtracts one color from another.
            /// </summary>
            Subtract,
            /// <summary>
            /// Uses the darker value from each color channel.
            /// </summary>
            Darken,
            /// <summary>
            /// Uses the lighter value from each color channel.
            /// </summary>
            Lighten,
            /// <summary>
            /// Applies overlay blending.
            /// </summary>
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

        /// <summary>
        /// Returns a new color with the minimum values from each channel of two colors.
        /// </summary>
        /// <param name="c1">First color.</param>
        /// <param name="c2">Second color.</param>
        /// <returns>Color with min values from each channel.</returns>
        public static Color MinWith(this Color c1, Color c2) {
            var r = Mathf.Min(c1.r, c2.r);
            var g = Mathf.Min(c1.g, c2.g);
            var b = Mathf.Min(c1.b, c2.b);
            var a = Mathf.Min(c1.a, c2.a);
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// Returns a new color with the maximum values from each channel of two colors.
        /// </summary>
        /// <param name="c1">First color.</param>
        /// <param name="c2">Second color.</param>
        /// <returns>Color with max values from each channel.</returns>
        public static Color MaxWith(this Color c1, Color c2) {
            var r = Mathf.Max(c1.r, c2.r);
            var g = Mathf.Max(c1.g, c2.g);
            var b = Mathf.Max(c1.b, c2.b);
            var a = Mathf.Max(c1.a, c2.a);
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// Blends two colors using the specified blend mode.
        /// </summary>
        /// <param name="a">The base color.</param>
        /// <param name="b">The blend color.</param>
        /// <param name="mode">Blend mode to use.</param>
        /// <returns>The blended color.</returns>
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

        /// <summary>
        /// Lightens the color by blending with white at 50% alpha.
        /// </summary>
        /// <param name="a">The color to lighten.</param>
        /// <returns>The lightened color.</returns>
        public static Color Lighten(this Color a) {
            return a.Lighten(Color.white.WithAlpha(0.5f));
        }

        /// <summary>
        /// Lightens the color by blending with another color.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Color to lighten with.</param>
        /// <returns>The lightened color.</returns>
        public static Color Lighten(this Color a, Color b) {
            Color c = new Color();

            c.r = Lighten(a.r, b.r);
            c.g = Lighten(a.g, b.g);
            c.b = Lighten(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        /// <summary>
        /// Darkens the color by blending with black at 50% alpha.
        /// </summary>
        /// <param name="a">The color to darken.</param>
        /// <returns>The darkened color.</returns>
        public static Color Darken(this Color a) {
            return a.Lighten(Color.black.WithAlpha(0.5f));
        }

        /// <summary>
        /// Darkens the color by blending with another color.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Color to darken with.</param>
        /// <returns>The darkened color.</returns>
        public static Color Darken(this Color a, Color b) {
            Color c = new Color();


            c.r = Mathf.Min(a.r, b.r);
            c.g = Mathf.Min(a.g, b.g);
            c.b = Mathf.Min(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        /// <summary>
        /// Applies an overlay blend between two colors.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Overlay color.</param>
        /// <returns>The overlay blended color.</returns>
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

        /// <summary>
        /// Applies a hard light blend between two colors.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Hard light color.</param>
        /// <returns>The hard light blended color.</returns>
        public static Color HardLight(this Color a, Color b) {
            Color c = new Color();

            c.r = HardLight(a.r, b.r);
            c.g = HardLight(a.g, b.g);
            c.b = HardLight(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        /// <summary>
        /// Applies a soft light blend between two colors.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Soft light color.</param>
        /// <returns>The soft light blended color.</returns>
        public static Color SoftLight(this Color a, Color b) {
            Color c = new Color();

            c.r = SoftLight(a.r, b.r);
            c.g = SoftLight(a.g, b.g);
            c.b = SoftLight(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        /// <summary>
        /// Applies a difference blend between two colors.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Difference color.</param>
        /// <returns>The difference blended color.</returns>
        public static Color Difference(this Color a, Color b) {
            Color c = new Color();

            c.r = Difference(a.r, b.r);
            c.g = Difference(a.g, b.g);
            c.b = Difference(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        /// <summary>
        /// Applies an exclusion blend between two colors.
        /// </summary>
        /// <param name="a">Base color.</param>
        /// <param name="b">Exclusion color.</param>
        /// <returns>The exclusion blended color.</returns>
        public static Color Exclusion(this Color a, Color b) {
            Color c = new Color();

            c.r = Exclusion(a.r, b.r);
            c.g = Exclusion(a.g, b.g);
            c.b = Exclusion(a.b, b.b);

            c = ((1f - b.a) * a) + (b.a * c);
            c.a = a.a + b.a * (1f - a.a);
            return c;
        }

        /// <summary>
        /// Converts a color to a <see cref="Vector3"/> using its RGBA channels.
        /// </summary>
        /// <param name="c">The color to convert.</param>
        /// <returns>A <see cref="Vector3"/> with RGB values and alpha as Z.</returns>
        public static Vector3 ToVector3(this Color c) {
            return (Vector3)c.ToVector4();
        }

        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the red and green channels.
        /// </summary>
        public static Vector2 XY(this Color c) { return new Vector2(c.r, c.g); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the red and blue channels.
        /// </summary>
        public static Vector2 XZ(this Color c) { return new Vector2(c.r, c.b); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the red and alpha channels.
        /// </summary>
        public static Vector2 XW(this Color c) { return new Vector2(c.r, c.a); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the green and red channels.
        /// </summary>
        public static Vector2 YX(this Color c) { return new Vector2(c.g, c.r); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the green and blue channels.
        /// </summary>
        public static Vector2 YZ(this Color c) { return new Vector2(c.g, c.b); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the green and alpha channels.
        /// </summary>
        public static Vector2 YW(this Color c) { return new Vector2(c.g, c.a); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the blue and red channels.
        /// </summary>
        public static Vector2 ZX(this Color c) { return new Vector2(c.b, c.r); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the blue and green channels.
        /// </summary>
        public static Vector2 ZY(this Color c) { return new Vector2(c.b, c.g); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the blue and alpha channels.
        /// </summary>
        public static Vector2 ZW(this Color c) { return new Vector2(c.b, c.a); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the red channel twice.
        /// </summary>
        public static Vector2 XX(this Color c) { return new Vector2(c.r, c.r); }
        /// <summary>
        /// Gets a <see cref="Vector3"/> containing the red channel three times.
        /// </summary>
        public static Vector3 XXX(this Color c) { return new Vector3(c.r, c.r, c.r); }
        /// <summary>
        /// Gets a <see cref="Vector4"/> containing the red channel four times.
        /// </summary>
        public static Vector4 XXXX(this Color c) { return new Vector4(c.r, c.r, c.r, c.r); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the green channel twice.
        /// </summary>
        public static Vector2 YY(this Color c) { return new Vector2(c.g, c.g); }
        /// <summary>
        /// Gets a <see cref="Vector3"/> containing the green channel three times.
        /// </summary>
        public static Vector3 YYY(this Color c) { return new Vector3(c.g, c.g, c.g); }
        /// <summary>
        /// Gets a <see cref="Vector4"/> containing the green channel four times.
        /// </summary>
        public static Vector4 YYYY(this Color c) { return new Vector4(c.g, c.g, c.g, c.g); }
        /// <summary>
        /// Gets a <see cref="Vector2"/> containing the blue channel twice.
        /// </summary>
        public static Vector2 ZZ(this Color c) { return new Vector2(c.b, c.b); }
        /// <summary>
        /// Gets a <see cref="Vector3"/> containing the blue channel three times.
        /// </summary>
        public static Vector3 ZZZ(this Color c) { return new Vector3(c.b, c.b, c.b); }
        /// <summary>
        /// Gets a <see cref="Vector4"/> containing the blue channel four times.
        /// </summary>
        public static Vector4 ZZZZ(this Color c) { return new Vector4(c.b, c.b, c.b, c.b); }
        /// <summary>
        /// Gets a <see cref="Vector3"/> containing the red, green, and blue channels.
        /// </summary>
        public static Vector3 XYZ(this Color c) { return c.ToVector3(); }
    }
}