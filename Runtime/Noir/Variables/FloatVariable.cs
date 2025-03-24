#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System;
using UnityEngine;

namespace Noir.Variables {
    [CreateAssetMenu(fileName = "FloatVariable.asset", menuName = "Noir/Data/Float Variable", order = 0)]
    public class FloatVariable : DataVariable<float>, IEquatable<FloatVariable>, IEquatable<DataVariable<float>> {

        [SerializeField]
#if ODIN_INSPECTOR
        [HideInTables]
#endif
        private bool _clampValue;

#if ODIN_INSPECTOR
        [ShowIf("_clampValue")]
        [HideInTables]
#endif
        [SerializeField]
        private float _clampMin;

#if ODIN_INSPECTOR
        [ShowIf("_clampValue")]
        [HideInTables]
#endif
        [SerializeField]
        private float _clampMax;

        protected override void OnAfterSave(object previousValue, object newValue) {
            if (_clampValue) {
                var clamped = Mathf.Clamp((float)newValue, _clampMin, _clampMax);
                if (!Application.isPlaying || IsPersistant) {
                    SavedValue = clamped;
                }
                EphemeralValue = clamped;
            }
        }

        bool IEquatable<FloatVariable>.Equals(FloatVariable other) {
            if (!other) return false;
            return other.Value == Value;
        }

        bool IEquatable<DataVariable<float>>.Equals(DataVariable<float> other) {
            if (!other) return false;
            return other.Value == Value;
        }

        public static bool operator ==(FloatVariable x, FloatVariable y) {
            if (!x || !y) {
                return (UnityEngine.Object)x == (UnityEngine.Object)y;
            }
            return x.Value == y.Value;
        }

        public static bool operator !=(FloatVariable x, FloatVariable y) {
            if (!x || !y) {
                return (UnityEngine.Object)x != (UnityEngine.Object)y;
            }
            return x.Value != y.Value;
        }
    }
}