using System;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using UnityEngine;

namespace Noir.Variables {
    [CreateAssetMenu(fileName = "ProgressVariable.asset", menuName = "Noir/Data/Progress Variable", order = 0)]
    public class ProgressVariable : DataVariable<float>,  IEquatable<DataVariable<float>> {

        #if ODIN_INSPECTOR
        [HideIf("@_currentIntValue != null")]
        [HideInTables]
        #endif
        [SerializeField] private FloatVariable _currentFloatValue;
        #if ODIN_INSPECTOR
        [HideIf("@_minIntValue != null")]
        [HideInTables]
        #endif
        [SerializeField] private FloatVariable _minFloatValue;
        #if ODIN_INSPECTOR
        [HideIf("@_maxIntValue != null")]
        [HideInTables]
        #endif
        [SerializeField] private FloatVariable _maxFloatValue;

        #if ODIN_INSPECTOR
        [HideIf("@_currentFloatValue != null")]
        [HideInTables]
        #endif
        [SerializeField] private IntVariable _currentIntValue;
        #if ODIN_INSPECTOR
        [HideIf("@_minFloatValue != null")]
        [HideInTables]
        #endif
        [SerializeField] private IntVariable _minIntValue;
        #if ODIN_INSPECTOR
        [HideIf("@_maxFloatValue != null")]
        [HideInTables]
        #endif
        [SerializeField] private IntVariable _maxIntValue;

        [SerializeField] private bool _invert;

        private float MinValue {
            get {
                if (!_minFloatValue && !_minIntValue) return 0f;
                return _minFloatValue?.Value ?? _minIntValue?.Value ?? 0f;
            }
        }

        private float MaxValue {
            get {
                if (!_maxFloatValue && !_maxIntValue) return 0f;
                return _maxFloatValue?.Value ?? _maxIntValue?.Value ?? 0f;
            }
        }

        private float CurrentValue {
            get {
                if (!_currentFloatValue && !_currentIntValue) return 0f;
                return _currentFloatValue?.Value ?? _currentIntValue?.Value ?? 0f;
            }
        }


#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
        [ProgressBar(0f, 1f)]
#endif
        public override float Value {
            get {
                var value = 0f;
                if (CurrentValue > MaxValue) value = 1f;
                value = CurrentValue/MaxValue;
                return _invert ? 1f - value : value;
            }
            set {
                // do nothing
            }
        }

        bool IEquatable<DataVariable<float>>.Equals(DataVariable<float> other) {
            if (!other) return false;
            return other.Value.Equals(Value);
        }
    }
}