﻿#if ODIN_INSPECTOR
using Sirenix.OdinInspector;
#endif
using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Noir.Variables {
    public delegate void DataVariableChanged<T>(T oldValue, T newValue);
    public delegate void OnBeforeChange();
    public delegate void OnAfterChange();

    public abstract class DataVariable : ScriptableObject {
        [SerializeField]
#if ODIN_INSPECTOR
        [PropertyOrder(0)]
        [HideInInlineEditors]
        [HideInTables]
#endif
        private bool _isPersistant = true;

        [SerializeField]
#if ODIN_INSPECTOR
        [DisplayAsString]
        [TableColumnWidth(100, Resizable = true)]
        [PropertyOrder(-3)]
#endif
        private string _friendlyName;

        [SerializeField]
#if ODIN_INSPECTOR
        [TableColumnWidth(100, Resizable = true)]
        [PropertyOrder(-2)]
#endif
        private string _description;

        /// <summary>
        /// The variable name.
        /// </summary>
#if ODIN_INSPECTOR
        [DelayedProperty]
        [ShowInInspector]
        [TableColumnWidth(100, Resizable = true)]
        [PropertyOrder(-4)]
#endif
        public string Name {
            get => name;
            #if UNITY_EDITOR
            set {
                name = value;
                UnityEditor.AssetDatabase.RenameAsset(UnityEditor.AssetDatabase.GetAssetPath(this), name);
                UnityEditor.EditorUtility.SetDirty(this);
                UnityEditor.AssetDatabase.SaveAssetIfDirty(this);
            }
            #endif
        }

        /// <summary>
        /// The friendly name of the variable.
        /// </summary>
        public string FriendlyName {
            get => _friendlyName;
            set => _friendlyName = value;
        }

        /// <summary>
        /// The description of the variable.
        /// </summary>
        public string Description {
            get => _description;
            set => _description = value;
        }

        public event OnBeforeChange OnBeforeVariableChanged;
        public event OnAfterChange OnAfterVariableChanged;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is persisted to disk when changed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is persistant; otherwise, <c>false</c>.
        /// </value>
        public bool IsPersistant {
            get => _isPersistant;
            set => _isPersistant = value;
        }

        public abstract object ToObject();

        /// <summary>
        /// Tries to set the given <see cref="value"/> into the variable.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <param name="silently"><c>true</c> if no events should be triggered during the set, <c>false</c> to trigger the normal change events. Defaults to <c>false</c>.</param>
        /// <returns><c>true</c> if the value was set successfully, <c>false</c> otherwise.</returns>
        public abstract bool TrySetValue(object value, bool silently = false);

        protected virtual void OnBeforeChange() {
            OnBeforeVariableChanged?.Invoke();
        }

        protected virtual void OnAfterSave(object previousValue, object newValue) {
            OnAfterVariableChanged?.Invoke();
        }
    }

    public interface IDataVariable {
        object ToObject();
    }

    [Serializable]
    public class DataVariable<T> : DataVariable, IDataVariable, IEquatable<T> {
        [FormerlySerializedAs("Value")]
        [HideInInspector]
        [SerializeField] private T _savedValue;

        [NonSerialized]
        private T _ephemeralValue;

        public event DataVariableChanged<T> OnDataVariableChanged;

        // called by unit tests
        /// <summary>
        /// The long-term or saved value of the variable.
        /// </summary>
#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
        [HideInInlineEditors]
        [HideInTables]
#endif
        internal T SavedValue {
            get => _savedValue;
            set => _savedValue = value;
        }

        // called by unit tests
        /// <summary>
        /// The short-lived value of the variable. This property is never serialized with the variable scriptable object.
        /// </summary>
#if ODIN_INSPECTOR
        [ReadOnly]
        [ShowInInspector]
        [HideInInlineEditors]
        [HideInTables]
#endif
        internal T EphemeralValue {
            get => _ephemeralValue;
            set => _ephemeralValue = value;
        }

        internal void Initialize() {
            _ephemeralValue = _savedValue;
        }

        /// <summary>
        /// The value for the current variable.
        /// </summary>
#if ODIN_INSPECTOR
        [ShowInInspector]
        [TableColumnWidth(64)]
#endif
        public virtual T Value {
            get {
#if UNITY_EDITOR
                if (!Application.isPlaying) {
                    return _savedValue;
                }
#endif
                return _ephemeralValue;
            }
            set {
                OnBeforeChange();
                var previousValue = _ephemeralValue;
                _ephemeralValue = value;
                var shouldFireChangeEvent = !previousValue?.Equals(value) ?? true;
                if (shouldFireChangeEvent) OnDataVariableChanged?.Invoke(previousValue, value);
#if UNITY_EDITOR
                if (!Application.isPlaying) {
                    _savedValue = value;
                }
#endif
                if (IsPersistant) {
                    _savedValue = value;
                }
                OnAfterSave(previousValue, value);
            }
        }

        public static implicit operator T(DataVariable<T> variable) {
            return variable == null ? default(T) : variable.Value;
        }

        /// <inheritdoc />
        public override bool TrySetValue(object value, bool silently = false) {
            if (value is T tValue) {
                if (silently) {
                    _ephemeralValue = tValue;
                    if (IsPersistant || !Application.isPlaying) {
                        _savedValue = tValue;
                    }

                    return true;
                }
                Value = tValue;
                return true;
            }
            return false;
        }

        public override string ToString() {
            return Value.ToString();
        }

        public override object ToObject() {
            return Value;
        }

        bool IEquatable<T>.Equals(T other) {
            return Value.Equals(other);
        }

        private void Awake() {
            Initialize();
        }

#if UNITY_EDITOR
        private void OnValidate() {
            Value = _savedValue;
        }
#endif
    }
}