using System;
using UnityEngine;

namespace Noir.Randomness {
    [Serializable]
    public class PoissonPointSet {
        [SerializeField] private Vector2[] _points;

        public Vector2[] Points {
            get => _points;
            set => _points = value;
        }
    }
}