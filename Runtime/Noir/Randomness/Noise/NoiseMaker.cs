using UnityEngine;

namespace Noir.Randomness.Noise {
    public class NoiseMaker {
        private readonly NoiseSettings _settings;
        private readonly FastNoiseLite _noise;

        public NoiseMaker(NoiseSettings settings) {
            _settings = settings;
            _noise = CreateNoise(_settings);
        }

        public float GetNoise(float x, float y) {
            var n = _noise.GetNoise(x, y) / _settings.Scale + _settings.Offset;
            n = Mathf.Clamp01(n) * (((float)_settings.Weight)/100f);
            return n;
        }

        private FastNoiseLite CreateNoise(NoiseSettings settings) {
            var noise = new FastNoiseLite();
            noise.SetNoiseType(settings.NoiseType);
            noise.SetSeed(settings.Seed);
            noise.SetFrequency(settings.FrequencyCalc);
            noise.SetFractalType(settings.FractalType);
            noise.SetFractalOctaves(settings.FractalOctaves);
            noise.SetFractalLacunarity(settings.FractalLacunarity);
            noise.SetFractalGain(settings.FractalGain);
            noise.SetFractalWeightedStrength(settings.FractalWeightedStrength);
            noise.SetDomainWarpType(settings.DomainWarp);
            noise.SetCellularDistanceFunction(settings.CellularDistance);
            noise.SetCellularJitter(settings.CellularJitter);
            noise.SetCellularReturnType(settings.CellularReturnType);
            noise.SetDomainWarpAmp(settings.DomainWarpAmplitude);
            noise.SetFractalPingPongStrength(settings.FractalPingPongStrength);
            return noise;
        }
    }
}
