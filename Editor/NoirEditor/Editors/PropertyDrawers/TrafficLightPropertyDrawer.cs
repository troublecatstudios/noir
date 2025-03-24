using UnityEngine;
using UnityEditor;
using Noir.Attributes;

namespace NoirEditor.Editors.PropertyDrawers {
    [CustomPropertyDrawer(typeof(TrafficLightAttribute), true)]
    public class TrafficLightDrawer : PropertyDrawer {
        TrafficLightAttribute trafficLight;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            if (!string.IsNullOrEmpty(trafficLight.CustomLabel)) {
                label = new GUIContent(trafficLight.CustomLabel);
            }

            // store the attribute, it will be helpful!
            trafficLight = attribute as TrafficLightAttribute;

            // If were being directed to draw a label, Make sure it goes down first
            if (trafficLight.DrawLabel) {
                label = EditorGUI.BeginProperty(position, label, property);

                if (trafficLight.AlsoDrawDefault) {
                    // dont supply a control id (for label highlighting and selecting).
                    // this will auto use the next one thats drawn (via EditorGUI.PropertyField)
                    position = EditorGUI.PrefixLabel(position, label);
                } else {
                    // becuase no editable control will be displayed, just the control image
                    // we need to mark ourselves as passive
                    position = EditorGUI.PrefixLabel(position, EditorGUIUtility.GetControlID(FocusType.Passive), label);
                }
            }

            // figure out what kinda type were drawing....
            switch (property.propertyType) {
                // Bools are supported with either one or two lights
                case SerializedPropertyType.Boolean:
                    bool val = property.boolValue;
                    if (trafficLight.LightCount == 1) {
                        TrafficLightGUI.DrawTrafficLightSingle(position, GetLightColor(val, 0));
                    } else if (trafficLight.LightCount == 2) {
                        TrafficLightGUI.DrawTrafficLightDouble(position, GetLightColor(!val, 0), GetLightColor(val, 1));
                    }
                    break;
                // Ints/Floats/Enums are all treated as ints. The light matching the current
                // int value of the property will be lit up by default. If the FillLights flag
                // is set, instead all values up to and including the current int value will be
                // lit.
                case SerializedPropertyType.Integer:
                    int i = Mathf.Clamp(property.intValue, -1, trafficLight.LightCount - 1);
                    bool[] active = FillActiveLightArray(i);
                    DrawActiveLights(position, active);
                    break;
                case SerializedPropertyType.Float:
                    i = Mathf.Clamp((int)property.floatValue, 0, trafficLight.LightCount - 1);
                    active = FillActiveLightArray(i);
                    DrawActiveLights(position, active);
                    break;
                case SerializedPropertyType.Enum:
                    i = Mathf.Clamp(property.enumValueIndex, 0, trafficLight.LightCount - 1);
                    active = FillActiveLightArray(i);
                    DrawActiveLights(position, active);
                    break;
                // TODO vectors could be treated as arrays that map to 2/3/4 light
                case SerializedPropertyType.Vector2:
                    active = FillActiveLightArray(property.vector2Value);
                    DrawActiveLights(position, active);
                    break;
                // TrafficLights, each field controling a single light?
                default:
                    // NOT SUPPORTED OOPS
                    // and probably just dosnt make sense!
                    break;
            }

            var sizeType = GetLightSize();
            float size = TrafficLightGUI.GetTrafficLightSize(sizeType).y;

            if (trafficLight.AlsoDrawDefault) {
                // Offset the default property so it looks better, as the stock art
                // for the traffic light control is a bit larger than a line
                position.position += new Vector2(0, 3);
                position.width -= TrafficLightGUI.GetTrafficLightSize(sizeType).x + 2;
                position.x += TrafficLightGUI.GetTrafficLightSize(sizeType).x + 2;

                // Draw the default property control without a label, cos we already did it if we wanted it
                EditorGUI.PropertyField(position, property, GUIContent.none, true);
            }

            if (trafficLight.DrawLabel) {
                EditorGUI.EndProperty();
            }

        }

        #region Helpers
        // these methods help with drawing trafficlights, especally the larger int lights
        private TrafficLightColor GetLightColor(bool val, int i) {
            return val ? trafficLight.Colors[i] : TrafficLightColor.Off;
        }

        private bool[] FillActiveLightArray(int val) {
            bool[] active = new bool[trafficLight.LightCount];

            for (int x = 0; x < trafficLight.LightCount; x++) {
                if (trafficLight.FillLights) {
                    active[x] = (val >= 0 && x <= val);
                } else {
                    active[x] = x == val;
                }
            }

            return active;
        }

        private bool[] FillActiveLightArray(Vector2 vector2Value) {
            return new[] { vector2Value[0] >= 1, vector2Value[1] >= 1 };
        }

        private void DrawActiveLights(Rect position, bool[] active) {
            int length = active.Length;
            if (length == 1) {
                TrafficLightGUI.DrawTrafficLightSingle(position, GetLightColor(active[0], 0));
            } else if (length == 2) {
                TrafficLightGUI.DrawTrafficLightDouble(position, GetLightColor(active[0], 0), GetLightColor(active[1], 1));
            } else if (length == 3) {
                TrafficLightGUI.DrawTrafficLightTriple(position, GetLightColor(active[0], 0), GetLightColor(active[1], 1), GetLightColor(active[2], 2));
            } else if (length == 4) {
                TrafficLightGUI.DrawTrafficLightQuad(position, GetLightColor(active[0], 0), GetLightColor(active[1], 1), GetLightColor(active[2], 2), GetLightColor(active[3], 3));
            }
        }

        private TrafficLightSize GetLightSize() {
            return (TrafficLightSize)(trafficLight.LightCount - 1);
        }
        #endregion

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            trafficLight = attribute as TrafficLightAttribute;

            var sizeType = GetLightSize(); // all lights are 20px with the default art
            float size = TrafficLightGUI.GetTrafficLightSize(sizeType).y;

            if (trafficLight.AlsoDrawDefault) {
                size = Mathf.Max(size, EditorGUI.GetPropertyHeight(property));
            }


            return size;
        }
    }
}