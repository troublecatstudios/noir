using Noir;
using NoirEditor.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace NoirEditor.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(Vector4Int), true)]
    public class Vector4IntPropertyDrawer : PropertyDrawer {
        private SerializedProperty _x, _y, _z, _w;
        private bool _cache = false;
        private string _name;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if (!_cache) {
                //get the name before it's gone
                _name = property.displayName;

                //get the X and Y values
                property.Next(true);
                _x = property.Copy();
                property.Next(true);
                _y = property.Copy();
                property.Next(true);
                _z = property.Copy();
                property.Next(true);
                _w = property.Copy();

                _cache = true;
            }
            Rect contentPosition = EditorGUI.PrefixLabel(position, new GUIContent(_name));

            if (position.height > 16f) {
                position.height = 16f;
                EditorGUI.indentLevel += 1;
                contentPosition = EditorGUI.IndentedRect(position);
                contentPosition.y += 18f;
            }

            float quarter = contentPosition.width / 4;
            GUI.skin.label.padding = new RectOffset(3, 3, 6, 6);

            //show the X and Y from the point
            EditorGUIUtility.labelWidth = 14f;
            contentPosition.width *= 0.5f;
            EditorGUI.indentLevel = 0;

            if (GUI.enabled) {
                EditorGUI.BeginProperty(contentPosition, label, _x);
                EditorGUI.BeginChangeCheck();
                var newVal = EditorGUI.IntField(contentPosition, new GUIContent("x"), _x.intValue);
                if (EditorGUI.EndChangeCheck())
                    _x.intValue = newVal;
                EditorGUI.EndProperty();
            } else EditorGUI.LabelField(contentPosition, $"x: {_x.intValue}");

            contentPosition.x += quarter;
            if (GUI.enabled) {
                EditorGUI.BeginProperty(contentPosition, label, _y);
                EditorGUI.BeginChangeCheck();
                var newVal = EditorGUI.IntField(contentPosition, new GUIContent("y"), _y.intValue);
                if (EditorGUI.EndChangeCheck())
                    _y.intValue = newVal;
                EditorGUI.EndProperty();
            } else EditorGUI.LabelField(contentPosition, $"y: {_y.intValue}");

            contentPosition.x += quarter;
            if (GUI.enabled) {
                EditorGUI.BeginProperty(contentPosition, label, _z);
                EditorGUI.BeginChangeCheck();
                var newVal = EditorGUI.IntField(contentPosition, new GUIContent("z"), _z.intValue);
                if (EditorGUI.EndChangeCheck())
                    _z.intValue = newVal;
                EditorGUI.EndProperty();
            } else EditorGUI.LabelField(contentPosition, $"z: {_z.intValue}");


            contentPosition.x += quarter;
            if (GUI.enabled) {
                EditorGUI.BeginProperty(contentPosition, label, _w);
                EditorGUI.BeginChangeCheck();
                var newVal = EditorGUI.IntField(contentPosition, new GUIContent("w"), _w.intValue);
                if (EditorGUI.EndChangeCheck())
                    _w.intValue = newVal;
                EditorGUI.EndProperty();
            } else EditorGUI.LabelField(contentPosition, $"w: {_w.intValue}");
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            return Screen.width < 333 ? (16f + 18f) : 16f;
        }
    }
}