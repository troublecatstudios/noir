using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NoirUnityEditor.Modifications.Hierarchy {
    [InitializeOnLoad]
    internal class CustomHierarchyIcons {
        private static Texture[] CustomIcons = null;
        private static float _lastLoadTime = 0f;
        private static float _checkInterval = 30f;
        private static float _maxCheckInterval = 120f;
        private static float _minCheckInterval = 30f;
        private static readonly Dictionary<string, Texture> _lookup = new Dictionary<string, Texture>();

        static CustomHierarchyIcons() {
            EditorApplication.hierarchyWindowItemOnGUI += HandleHierarchyWindowItemOnGUI;
            CustomIcons = Resources.LoadAll<Texture>("CustomHierarchyIcons");
        }

        private static void HandleHierarchyWindowItemOnGUI(int instanceID, Rect selectionRect) {
            if (Time.realtimeSinceStartup - _lastLoadTime > _checkInterval) {
                var newIcons = Resources.LoadAll<Texture>("CustomHierarchyIcons");

                if (_lookup.Count != newIcons.Length || newIcons.Length != CustomIcons.Length) {
                    _lookup.Clear();
                    _checkInterval = _minCheckInterval;
                    CustomIcons = newIcons;
                    foreach (var icon in newIcons) {
                        _lookup.Add(icon.name, icon);
                    }
                    _lastLoadTime = Time.realtimeSinceStartup;
                } else {
                    _checkInterval = Mathf.Clamp(_checkInterval * 2, _minCheckInterval, _maxCheckInterval);
                }
            }

            if (_lookup.Count == 0) return;
            var gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
            if (!gameObject) return;

            var components = gameObject.GetComponents<Component>();
            foreach (var component in components) {
                if (!component) continue;
                var name = component.GetType().Name;
                if (_lookup.TryGetValue(name, out var icon)) {
                    GUI.DrawTexture(new Rect(selectionRect.xMax - 16, selectionRect.yMin, 16, 16), icon);
                    break;
                }
            }
        }
    }
}
