using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Noir {

    /// <summary>
    /// Specifies the different types of easing functions for interpolation.
    /// </summary>
    public enum EaseType {
        /// <summary>
        /// Linear easing (no acceleration).
        /// </summary>
        Linear,
        /// <summary>
        /// Quadratic in easing (accelerating from zero velocity).
        /// </summary>
        QuadraticIn,
        /// <summary>
        /// Quadratic out easing (decelerating to zero velocity).
        /// </summary>
        QuadraticOut,
        /// <summary>
        /// Quadratic in-out easing (acceleration until halfway, then deceleration).
        /// </summary>
        QuadraticInOut,
        /// <summary>
        /// Quartic in easing (accelerating from zero velocity, fourth power).
        /// </summary>
        QuarticIn,
        /// <summary>
        /// Quartic out easing (decelerating to zero velocity, fourth power).
        /// </summary>
        QuarticOut,
        /// <summary>
        /// Quartic in-out easing (acceleration until halfway, then deceleration, fourth power).
        /// </summary>
        QuarticInOut,
        /// <summary>
        /// Quintic in easing (accelerating from zero velocity, fifth power).
        /// </summary>
        QuinticIn,
        /// <summary>
        /// Quintic out easing (decelerating to zero velocity, fifth power).
        /// </summary>
        QuinticOut,
        /// <summary>
        /// Quintic in-out easing (acceleration until halfway, then deceleration, fifth power).
        /// </summary>
        QuinticInOut,
        /// <summary>
        /// Cubic in easing (accelerating from zero velocity, third power).
        /// </summary>
        CubicIn,
        /// <summary>
        /// Cubic out easing (decelerating to zero velocity, third power).
        /// </summary>
        CubicOut,
        /// <summary>
        /// Cubic in-out easing (acceleration until halfway, then deceleration, third power).
        /// </summary>
        CubicInOut,
        /// <summary>
        /// Exponential in easing (accelerating from zero velocity, exponential curve).
        /// </summary>
        ExponentialIn,
        /// <summary>
        /// Exponential out easing (decelerating to zero velocity, exponential curve).
        /// </summary>
        ExponentialOut,
        /// <summary>
        /// Exponential in-out easing (acceleration until halfway, then deceleration, exponential curve).
        /// </summary>
        ExponentialInOut,
        /// <summary>
        /// Circular in easing (accelerating from zero velocity, circular curve).
        /// </summary>
        CircularIn,
        /// <summary>
        /// Circular out easing (decelerating to zero velocity, circular curve).
        /// </summary>
        CircularOut,
        /// <summary>
        /// Circular in-out easing (acceleration until halfway, then deceleration, circular curve).
        /// </summary>
        CircularInOut,
        /// <summary>
        /// Sinusoidal in easing (accelerating from zero velocity, sinusoidal curve).
        /// </summary>
        SinusoidalIn,
        /// <summary>
        /// Sinusoidal out easing (decelerating to zero velocity, sinusoidal curve).
        /// </summary>
        SinusoidalOut,
        /// <summary>
        /// Sinusoidal in-out easing (acceleration until halfway, then deceleration, sinusoidal curve).
        /// </summary>
        SinusoidalInOut,
        /// <summary>
        /// Elastic in easing (elastic bounce at the beginning).
        /// </summary>
        ElasticIn,
        /// <summary>
        /// Elastic out easing (elastic bounce at the end).
        /// </summary>
        ElasticOut,
        /// <summary>
        /// Elastic in-out easing (elastic bounce at the beginning and end).
        /// </summary>
        ElasticInOut,
        /// <summary>
        /// Bounce in easing (bouncing effect at the beginning).
        /// </summary>
        BounceIn,
        /// <summary>
        /// Bounce out easing (bouncing effect at the end).
        /// </summary>
        BounceOut,
        /// <summary>
        /// Bounce in-out easing (bouncing effect at both the beginning and end).
        /// </summary>
        BounceInOut,
        /// <summary>
        /// Back in easing (overshoots before accelerating forward).
        /// </summary>
        BackIn,
        /// <summary>
        /// Back out easing (overshoots at the end before settling).
        /// </summary>
        BackOut,
        /// <summary>
        /// Back in-out easing (overshoots at both the beginning and end).
        /// </summary>
        BackInOut
    }

    /// <summary>
    /// Provides easing functions for interpolation of various types.
    /// </summary>
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public static class Easing {

        /// <summary>
        /// Interpolates between two float values using the specified easing type.
        /// </summary>
        /// <param name="type">The type of easing function to apply.</param>
        /// <param name="from">The starting value.</param>
        /// <param name="to">The ending value.</param>
        /// <param name="t">The normalized time (0 to 1).</param>
        /// <returns>The interpolated value based on the easing function.</returns>
        public static float Ease(EaseType type, float from, float to, float t) {
            if (t <= 0) { return from; }
            if (t >= 1) { return to; }
            return Mathf.LerpUnclamped(from, to, Function(type)(t));
        }

        /// <summary>
        /// Interpolates between two <see cref="Vector3"/> values using the specified easing type.
        /// </summary>
        /// <param name="type">The type of easing function to apply.</param>
        /// <param name="from">The starting vector.</param>
        /// <param name="to">The ending vector.</param>
        /// <param name="t">The normalized time (0 to 1).</param>
        /// <returns>The interpolated <see cref="Vector3"/> value.</returns>
        public static Vector3 Ease(EaseType type, Vector3 from, Vector3 to, float t) {
            if (t <= 0) { return from; }
            if (t >= 1) { return to; }
            return Vector3.LerpUnclamped(from, to, Function(type)(t));
        }

        /// <summary>
        /// Interpolates between two <see cref="Quaternion"/> values using the specified easing type.
        /// </summary>
        /// <param name="type">The type of easing function to apply.</param>
        /// <param name="from">The starting quaternion.</param>
        /// <param name="to">The ending quaternion.</param>
        /// <param name="t">The normalized time (0 to 1).</param>
        /// <returns>The interpolated <see cref="Quaternion"/> value.</returns>
        public static Quaternion Ease(EaseType type, Quaternion from, Quaternion to, float t) {
            if (t <= 0) { return from; }
            if (t >= 1) { return to; }
            return Quaternion.LerpUnclamped(from, to, Function(type)(t));
        }

        /// <summary>
        /// Interpolates between two <see cref="Color"/> values using the specified easing type.
        /// </summary>
        /// <param name="type">The type of easing function to apply.</param>
        /// <param name="from">The starting color.</param>
        /// <param name="to">The ending color.</param>
        /// <param name="t">The normalized time (0 to 1).</param>
        /// <returns>The interpolated <see cref="Color"/> value.</returns>
        public static Color Ease(EaseType type, Color from, Color to, float t) {
            if (t <= 0) { return from; }
            if (t >= 1) { return to; }
            return Color.LerpUnclamped(from, to, Function(type)(t));
        }

        /// <summary>
        /// Gets the easing function delegate for the specified <see cref="EaseType"/>.
        /// </summary>
        /// <param name="type">The type of easing function.</param>
        /// <returns>A function that takes a normalized time and returns the eased value.</returns>
        public static Func<float, float> Function(EaseType type) {
            switch (type) {
                case EaseType.Linear: return Linear;
                case EaseType.QuadraticIn: return QuadraticIn;
                case EaseType.QuadraticOut: return QuadraticOut;
                case EaseType.QuadraticInOut: return QuadraticInOut;
                case EaseType.QuarticIn: return QuarticIn;
                case EaseType.QuarticOut: return QuarticOut;
                case EaseType.QuarticInOut: return QuarticInOut;
                case EaseType.QuinticIn: return QuinticIn;
                case EaseType.QuinticOut: return QuinticOut;
                case EaseType.QuinticInOut: return QuinticInOut;
                case EaseType.CubicIn: return CubicIn;
                case EaseType.CubicOut: return CubicOut;
                case EaseType.CubicInOut: return CubicInOut;
                case EaseType.ExponentialIn: return ExponentialIn;
                case EaseType.ExponentialOut: return ExponentialOut;
                case EaseType.ExponentialInOut: return ExponentialInOut;
                case EaseType.CircularIn: return CircularIn;
                case EaseType.CircularOut: return CircularOut;
                case EaseType.CircularInOut: return CircularInOut;
                case EaseType.SinusoidalIn: return SinusoidalIn;
                case EaseType.SinusoidalOut: return SinusoidalOut;
                case EaseType.SinusoidalInOut: return SinusoidalInOut;
                case EaseType.ElasticIn: return ElasticIn;
                case EaseType.ElasticOut: return ElasticOut;
                case EaseType.ElasticInOut: return ElasticInOut;
                case EaseType.BounceIn: return BounceIn;
                case EaseType.BounceOut: return BounceOut;
                case EaseType.BounceInOut: return BounceInOut;
                case EaseType.BackIn: return BackIn;
                case EaseType.BackOut: return BackOut;
                case EaseType.BackInOut: return BackInOut;
                default: throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>Linear easing (no acceleration).</summary>
        public static float Linear(float t) {
            return t;
        }

        /// <summary>Quadratic in easing (accelerating from zero velocity).</summary>
        public static float QuadraticIn(float t) {
            return t * t;
        }

        /// <summary>Quadratic out easing (decelerating to zero velocity).</summary>
        public static float QuadraticOut(float t) {
            return 1f - (1f - t) * (1f - t);
        }

        /// <summary>Quadratic in-out easing (acceleration until halfway, then deceleration).</summary>
        public static float QuadraticInOut(float t) {
            return t < 0.5f ? 2f * t * t : 1f - Mathf.Pow(-2f * t + 2f, 2f) / 2f;
        }

        /// <summary>Quartic in easing (accelerating from zero velocity).</summary>
        public static float QuarticIn(float t) {
            return t * t * t * t;
        }

        /// <summary>Quartic out easing (decelerating to zero velocity).</summary>
        public static float QuarticOut(float t) {
            return 1f - (--t * t * t * t);
        }

        /// <summary>Quartic in-out easing (acceleration until halfway, then deceleration).</summary>
        public static float QuarticInOut(float t) {
            if ((t *= 2f) < 1f)
                return 0.5f * t * t * t * t;
            return -0.5f * ((t -= 2f) * t * t * t - 2f);
        }

        /// <summary>Quintic in easing (accelerating from zero velocity).</summary>
        public static float QuinticIn(float t) {
            return t * t * t * t * t;
        }

        /// <summary>Quintic out easing (decelerating to zero velocity).</summary>
        public static float QuinticOut(float t) {
            return --t * t * t * t * t + 1f;
        }

        /// <summary>Quintic in-out easing (acceleration until halfway, then deceleration).</summary>
        public static float QuinticInOut(float t) {
            if ((t *= 2f) < 1)
                return 0.5f * t * t * t * t * t;
            return 0.5f * ((t -= 2f) * t * t * t * t + 2f);
        }

        /// <summary>Cubic in easing (accelerating from zero velocity).</summary>
        public static float CubicIn(float t) {
            return t * t * t;
        }

        /// <summary>Cubic out easing (decelerating to zero velocity).</summary>
        public static float CubicOut(float t) {
            return --t * t * t + 1f;
        }

        /// <summary>Cubic in-out easing (acceleration until halfway, then deceleration).</summary>
        public static float CubicInOut(float t) {
            return t < 0.5 ? 4f * t * t * t : 1f - Mathf.Pow(-2f * t + 2f, 3f) / 2f;
        }

        /// <summary>Sinusoidal in easing.</summary>
        public static float SinusoidalIn(float t) {
            return 1f - Mathf.Cos(t * Mathf.PI / 2f);
        }

        /// <summary>Sinusoidal out easing.</summary>
        public static float SinusoidalOut(float t) {
            return Mathf.Sin(t * Mathf.PI / 2f);
        }

        /// <summary>Sinusoidal in-out easing.</summary>
        public static float SinusoidalInOut(float t) {
            return 0.5f * (1f - Mathf.Cos(Mathf.PI * t));
        }

        /// <summary>Exponential in easing.</summary>
        public static float ExponentialIn(float t) {
            return t == 0f ? 0f : Mathf.Pow(2f, 10f * t - 10f);
        }

        /// <summary>Exponential out easing.</summary>
        public static float ExponentialOut(float t) {
            return t == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * t);
        }

        /// <summary>Exponential in-out easing.</summary>
        public static float ExponentialInOut(float t) {
            return t < 0.5f ? Mathf.Pow(2f, 20f * t - 10f) / 2f : (2f - Mathf.Pow(2f, -20f * t + 10f)) / 2f;
        }

        /// <summary>Circular in easing.</summary>
        public static float CircularIn(float t) {
            return 1f - Mathf.Sqrt(1f - t * t);
        }

        /// <summary>Circular out easing.</summary>
        public static float CircularOut(float t) {
            return Mathf.Sqrt(1f - (--t * t));
        }

        /// <summary>Circular in-out easing.</summary>
        public static float CircularInOut(float t) {
            return t < 0.5f ? (Mathf.Sqrt(1f - t * t) - 1f) / 2 : (Mathf.Sqrt(1f - (t -= 2f) * t) + 1f) / 2;
        }

        /// <summary>Elastic in easing.</summary>
        public static float ElasticIn(float t) {
            float x = (2f * Mathf.PI) / 3f;
            return -Mathf.Pow(2f, 10f * t - 10f) * Mathf.Sin((t * 10f - 10.75f) * x);
        }

        /// <summary>Elastic out easing.</summary>
        public static float ElasticOut(float t) {
            float x = (2f * Mathf.PI) / 3f;
            return Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * 10f - 0.75f) * x) + 1f;
        }

        /// <summary>Elastic in-out easing.</summary>
        public static float ElasticInOut(float t) {
            float x = (2f * Mathf.PI) / 4.5f;
            if (t < 0.5f)
                return -(Mathf.Pow(2f, 20f * t - 10f) * Mathf.Sin((20f * t - 11.125f) * x)) / 2f;
            return (Mathf.Pow(2f, -20f * t + 10f) * Mathf.Sin((20f * t - 11.125f) * x)) / 2f + 1f;
        }

        /// <summary>Bounce in easing.</summary>
        public static float BounceIn(float t) {
            return 1f - BounceOut(1f - t);
        }

        /// <summary>Bounce out easing.</summary>
        public static float BounceOut(float t) {
            if (t < (1f / 2.75f)) {
                return 7.5625f * t * t;
            } else if (t < (2f / 2.75f)) {
                return 7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f;
            } else if (t < (2.5f / 2.75f)) {
                return 7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f;
            } else {
                return 7.5625f * (t -= (2.625f / 2.75f)) * t + 0.984375f;
            }
        }

        /// <summary>Bounce in-out easing.</summary>
        public static float BounceInOut(float t) {
            return t < 0.5f ? BounceIn(t * 2f) * 0.5f : BounceOut(t * 2f - 1f) * 0.5f + 0.5f;
        }

        /// <summary>Back in easing.</summary>
        public static float BackIn(float t) {
            float s = 1.70158f;
            return t * t * ((s + 1f) * t - s);
        }

        /// <summary>Back out easing.</summary>
        public static float BackOut(float t) {
            float s = 1.70158f;
            return --t * t * ((s + 1f) * t + s) + 1f;
        }

        /// <summary>Back in-out easing.</summary>
        public static float BackInOut(float t) {
            float s = 1.70158f * 1.525f;
            if ((t *= 2f) < 1f)
                return 0.5f * (t * t * ((s + 1) * t - s));
            return 0.5f * ((t -= 2f) * t * ((s + 1f) * t + s) + 2f);
        }
    }
}