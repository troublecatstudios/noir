#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System;
using UnityEngine;

namespace Noir.Randomness.Noise
{
    [Serializable]
    public struct NoiseSettings : IEquatable<NoiseSettings>
    {
        public static readonly NoiseSettings Empty = new();
        public static bool operator ==(NoiseSettings a, NoiseSettings b) => a.Equals(b);
        public static bool operator !=(NoiseSettings a, NoiseSettings b) => !a.Equals(b);

        public FastNoiseLite.NoiseType NoiseType;
        public int Seed;

        [Range(1, 1000)]
        public int Frequency;

        [Range(1.0f, 10.0f)]
        public float Scale;

        [Range(0.0f, 1.0f)]
        public float Offset;

        [Range(0, 100)]
        public int Weight;

        public FastNoiseLite.FractalType FractalType;
        public FastNoiseLite.DomainWarpType DomainWarp;
        public float DomainWarpAmplitude;

#if ODIN_INSPECTOR
        [ShowIf("@FractalType != FastNoiseLite.FractalType.None")]
        [BoxGroup("Fractal Options")]
#endif
        public int FractalOctaves;

#if ODIN_INSPECTOR
        [ShowIf("@FractalType != FastNoiseLite.FractalType.None")]
        [BoxGroup("Fractal Options")]
#endif
        public float FractalLacunarity;

#if ODIN_INSPECTOR
        [ShowIf("@FractalType != FastNoiseLite.FractalType.None")]
        [BoxGroup("Fractal Options")]
#endif
        public float FractalGain;

#if ODIN_INSPECTOR
        [ShowIf("@FractalType != FastNoiseLite.FractalType.None")]
        [BoxGroup("Fractal Options")]
#endif
        public float FractalWeightedStrength;

#if ODIN_INSPECTOR
        [ShowIf("@FractalType != FastNoiseLite.FractalType.None")]
        [BoxGroup("Fractal Options")]
#endif
        public float FractalPingPongStrength;

#if ODIN_INSPECTOR
        [ShowIf("@NoiseType == FastNoiseLite.NoiseType.Cellular")]
        [BoxGroup("Cellular Options")]
#endif
        public FastNoiseLite.CellularDistanceFunction CellularDistance;

#if ODIN_INSPECTOR
        [ShowIf("@NoiseType == FastNoiseLite.NoiseType.Cellular")]
        [BoxGroup("Cellular Options")]
#endif
        public FastNoiseLite.CellularReturnType CellularReturnType;

#if ODIN_INSPECTOR
        [ShowIf("@NoiseType == FastNoiseLite.NoiseType.Cellular")]
        [BoxGroup("Cellular Options")]
#endif
        public float CellularJitter;

        public float FrequencyCalc => (float)Frequency / 1000f;

        public override bool Equals(object obj)
        {
            if (obj is NoiseSettings other)
            {
                return Equals(other);
            }
            return base.Equals(obj);
        }

        public bool Equals(NoiseSettings other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CellularJitter) +
            HashCode.Combine(CellularReturnType) +
            HashCode.Combine(CellularDistance) +
            HashCode.Combine(FractalPingPongStrength) +
            HashCode.Combine(FractalWeightedStrength) +
            HashCode.Combine(FractalGain) +
            HashCode.Combine(FractalLacunarity) +
            HashCode.Combine(FractalOctaves) +
            HashCode.Combine(DomainWarpAmplitude) +
            HashCode.Combine(DomainWarp) +
            HashCode.Combine(FractalType) +
            HashCode.Combine(Weight) +
            HashCode.Combine(Offset) +
            HashCode.Combine(Scale) +
            HashCode.Combine(Frequency) +
            HashCode.Combine(Seed) +
            HashCode.Combine(NoiseType);
        }

        public override string ToString()
        {
            return $"noise=(type={NoiseType}, seed={Seed}, weight={Weight}, hash={GetHashCode()})";
        }
    }
}
