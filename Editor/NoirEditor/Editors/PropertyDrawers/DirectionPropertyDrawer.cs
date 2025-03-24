using Noir.Events;
#if ODIN_INSPECTOR
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
#endif
using UnityEditor;
using UnityEngine;

namespace Noir.Editing.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(Direction))]
    internal class DirectionPropertyDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            Debug.Log($"Hello!");
            base.OnGUI(position, property, label);
        }
    }
}