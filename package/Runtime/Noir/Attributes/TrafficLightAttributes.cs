using UnityEngine;

namespace Noir.Attributes {
    /// <summary>
    /// Represents the color of an individual light in a traffic light display.
    /// </summary>
    public enum TrafficLightColor {
        /// <summary>
        /// Indicates that the light is turned off or inactive.
        /// </summary>
        Off,

        /// <summary>
        /// Represents a red light, typically used to signal stop or error conditions.
        /// </summary>
        Red,

        /// <summary>
        /// Represents an amber (orange-yellow) light, often used to signal caution or a pending change.
        /// </summary>
        Amber,

        /// <summary>
        /// Represents a green light, typically used to signal go or normal operation.
        /// </summary>
        Green,

        /// <summary>
        /// Represents a yellow light, similar to amber but may be used for alternate signaling purposes.
        /// </summary>
        Yellow,

        /// <summary>
        /// Represents a blue light, often used for informational, auxiliary, or special-purpose indicators.
        /// </summary>
        Blue,

        /// <summary>
        /// Represents a pink light, which may be used for stylistic or status-specific indicators.
        /// </summary>
        Pink
    }

    /// <summary>
    /// Base class for attributes that draw traffic light indicators in the Unity Inspector.
    /// </summary>
    /// <remarks>
    /// Inherit from this class to create custom traffic light indicators of different sizes and color arrangements.
    /// </remarks>
    public abstract class TrafficLightAttribute : PropertyAttribute {
        /// <summary>
        /// If true, draws a label next to the traffic light indicator.
        /// </summary>
        public bool DrawLabel = true;

        /// <summary>
        /// An optional custom label to display instead of the field name.
        /// </summary>
        public string CustomLabel;

        /// <summary>
        /// If true, also draws the default property field in addition to the traffic light indicator.
        /// </summary>
        public bool AlsoDrawDefault;

        /// <summary>
        /// If true, fills the traffic lights with solid color instead of outlines.
        /// </summary>
        public bool FillLights;

        /// <summary>
        /// The total number of lights in the traffic light display.
        /// </summary>
        public int LightCount;

        /// <summary>
        /// The colors of the individual lights.
        /// </summary>
        public TrafficLightColor[] Colors;
    }

    /// <summary>
    /// Displays a single traffic light indicator in the Unity Inspector.
    /// </summary>
    public class SingleTrafficLight : TrafficLightAttribute {
        /// <summary>
        /// Creates a single green light indicator.
        /// </summary>
        public SingleTrafficLight() {
            LightCount = 1;
            Colors = new[] { TrafficLightColor.Green };
        }

        /// <summary>
        /// Creates a single light indicator with a specified color.
        /// </summary>
        /// <param name="a">The color of the light.</param>
        public SingleTrafficLight(TrafficLightColor a) {
            LightCount = 1;
            Colors = new[] { a };
        }
    }

    /// <summary>
    /// Displays a double traffic light indicator in the Unity Inspector.
    /// </summary>
    public class DoubleTrafficLight : TrafficLightAttribute {
        /// <summary>
        /// Creates a red and green traffic light indicator.
        /// </summary>
        public DoubleTrafficLight() {
            LightCount = 2;
            Colors = new[] { TrafficLightColor.Red, TrafficLightColor.Green };
        }

        /// <summary>
        /// Creates a two-light indicator with specified colors.
        /// </summary>
        public DoubleTrafficLight(TrafficLightColor a, TrafficLightColor b) {
            LightCount = 2;
            Colors = new[] { a, b };
        }
    }

    /// <summary>
    /// Displays a triple traffic light indicator in the Unity Inspector.
    /// </summary>
    public class TripleTrafficLight : TrafficLightAttribute {
        /// <summary>
        /// Creates a red, amber, and green traffic light indicator.
        /// </summary>
        public TripleTrafficLight() {
            LightCount = 3;
            Colors = new[] { TrafficLightColor.Red, TrafficLightColor.Amber, TrafficLightColor.Green };
        }

        /// <summary>
        /// Creates a three-light indicator with specified colors.
        /// </summary>
        public TripleTrafficLight(TrafficLightColor a, TrafficLightColor b, TrafficLightColor c) {
            LightCount = 3;
            Colors = new[] { a, b, c };
        }
    }

    /// <summary>
    /// Displays a quad traffic light indicator in the Unity Inspector.
    /// </summary>
    public class QuadTrafficLight : TrafficLightAttribute {
        /// <summary>
        /// Creates a four-light indicator with blue, green, yellow, and pink lights.
        /// </summary>
        public QuadTrafficLight() {
            LightCount = 4;
            Colors = new[] { TrafficLightColor.Blue, TrafficLightColor.Green, TrafficLightColor.Yellow, TrafficLightColor.Pink };
        }

        /// <summary>
        /// Creates a four-light indicator with specified colors.
        /// </summary>
        public QuadTrafficLight(TrafficLightColor a, TrafficLightColor b, TrafficLightColor c, TrafficLightColor d) {
            LightCount = 4;
            Colors = new[] { a, b, c, d };
        }
    }
}