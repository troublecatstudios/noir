using System.Collections.Generic;
using UnityEngine;

namespace Noir.Randomness {
    public class PoissonSampler {
        private readonly PoissonSettings _settings;
        private readonly PoissonBags _bags;
        private readonly System.Random _random;
        public PoissonSampler(PoissonSettings settings, PoissonBags? bags = null) {
            _settings = settings;
            _bags = bags ?? CreateBags();
            _random = new System.Random(settings.RandomSeed);
        }

        public List<Vector2> Points => _bags.SamplePoints;
        public List<Vector2> ActivePoints => _bags.ActivePoints;
        public Vector2? StartingPoint { get; private set; }

        public bool Next(out int iterations) {
            iterations = 0;
            if (_bags.SamplePoints.Count == 0) {
                GetFirstPoint();
            }
            // TODO: change this to be deterministic?
            //var index = UnityEngine.Random.Range(0, _bags.ActivePoints.Count);
            var index = _random.Next(0, _bags.ActivePoints.Count);
            var point = _bags.ActivePoints[index];
            var found = false;
            for(var k = 0; k < _settings.IterationsPerPoint; k++) {
                found = found | GetNextPoint(point);
                iterations++;
            }

            if(found == false) {
                _bags.ActivePoints.RemoveAt(index);
            }
            return _bags.ActivePoints.Count > 0;
        }

        private PoissonBags CreateBags() {
            return new PoissonBags()
            {
                Grid = new Vector2?[_settings.GridWidth + 1, _settings.GridHeight + 1],
                SamplePoints = new List<Vector2>(),
                ActivePoints = new List<Vector2>()
            };
        }

        private void GetFirstPoint() {
            // TODO: change this to be deterministic?
            var first = new Vector2(
                NextFloat(_settings.BottomLeft.x, _settings.TopRight.x),
                NextFloat(_settings.BottomLeft.y, _settings.TopRight.y)
                // UnityEngine.Random.Range(_settings.BottomLeft.x, _settings.TopRight.x),
                // UnityEngine.Random.Range(_settings.BottomLeft.y, _settings.TopRight.y)
            );
            if (_settings.StartingPoint.HasValue) {
                first = _settings.StartingPoint.Value;
            }
            StartingPoint = first;
            var index = PoissonDisc.GetGridIndex(first, _settings);

            _bags.Grid[index.x, index.y] = first;
            _bags.SamplePoints.Add(first);
            _bags.ActivePoints.Add(first);
        }

        private bool GetNextPoint(Vector2 point) {
            var found = false;
            var p = GetRandPosInCircle(_settings.MinimumDistance, 2f * _settings.MinimumDistance) + point;

            if (_settings.Dimension.Contains(p) == false) {
                return false;
            }

            var minimum = _settings.MinimumDistance * _settings.MinimumDistance;
            var index = PoissonDisc.GetGridIndex(p, _settings);
            var drop = false;

            // Although it is Mathf.CeilToInt(set.MinimumDistance / set.CellSize) in the formula, It will be 2 after all.
            var around = 2;
            var fieldMin = new Vector2Int(Mathf.Max(0, index.x - around), Mathf.Max(0, index.y - around));
            var fieldMax = new Vector2Int(Mathf.Min(_settings.GridWidth, index.x + around), Mathf.Min(_settings.GridHeight, index.y + around));

            for (var i = fieldMin.x; i <= fieldMax.x && drop == false; i++) {
                for (var j = fieldMin.y; j <= fieldMax.y && drop == false; j++) {
                    var q = _bags.Grid[i, j];
                    if (q.HasValue == true && (q.Value - p).sqrMagnitude <= minimum) {
                        drop = true;
                    }
                }
            }

            if (drop == false) {
                found = true;

                _bags.SamplePoints.Add(p);
                _bags.ActivePoints.Add(p);
                _bags.Grid[index.x, index.y] = p;
            }

            return found;
        }

        private float NextFloat(float min, float max) {
            var t = _random.Next(0, 65535);
            var range = (float)((float)t/65535f);
            var delta = max - min;
            return min + (delta * range);
        }

        private Vector2 GetRandPosInCircle(float fieldMin, float fieldMax) {
            var theta = NextFloat(0f, Mathf.PI * 2); //UnityEngine.Random.Range(0f, Mathf.PI * 2f);
            var r = NextFloat(fieldMin * fieldMin, fieldMax * fieldMax);
            //var radius = Mathf.Sqrt(UnityEngine.Random.Range(fieldMin * fieldMin, fieldMax * fieldMax));
            var radius = Mathf.Sqrt(r);

            return new Vector2(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta));
        }
    }
}