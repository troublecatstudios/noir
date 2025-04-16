using UnityEngine;

namespace Noir.Attributes {
    public enum TrafficLightColor
    {
        Off,
        Red,
        Amber,
        Green,
        Yellow,
        Blue,
        Pink
    }

    public abstract class TrafficLightAttribute : PropertyAttribute
    {
        public bool DrawLabel = true;
        public string CustomLabel;
        public bool AlsoDrawDefault;
        public bool FillLights;

        public int LightCount;
        public TrafficLightColor[] Colors;
    }

    public class SingleTrafficLight : TrafficLightAttribute
    {
        public SingleTrafficLight()
        {
            LightCount = 1;
            Colors = new [] { TrafficLightColor.Green };
        }

        public SingleTrafficLight(TrafficLightColor a)
        {
            LightCount = 1;
            Colors = new[] { a };
        }
    }

    public class DoubleTrafficLight : TrafficLightAttribute
    {
        public DoubleTrafficLight()
        {
            LightCount = 2;
            Colors = new[] { TrafficLightColor.Red, TrafficLightColor.Green };
        }

        public DoubleTrafficLight(TrafficLightColor a, TrafficLightColor b)
        {
            LightCount = 2;
            Colors = new[] { a, b };
        }
    }

    public class TripleTrafficLight : TrafficLightAttribute
    {
        public TripleTrafficLight()
        {
            LightCount = 3;
            Colors = new[] { TrafficLightColor.Red, TrafficLightColor.Amber, TrafficLightColor.Green };
        }

        public TripleTrafficLight(TrafficLightColor a, TrafficLightColor b, TrafficLightColor c)
        {
            LightCount = 3;
            Colors = new[] { a, b, c };
        }
    }

    public class QuadTrafficLight : TrafficLightAttribute
    {
        public QuadTrafficLight()
        {
            LightCount = 4;
            Colors = new[] { TrafficLightColor.Blue, TrafficLightColor.Green, TrafficLightColor.Yellow, TrafficLightColor.Pink };
        }

        public QuadTrafficLight(TrafficLightColor a, TrafficLightColor b, TrafficLightColor c, TrafficLightColor d)
        {
            LightCount = 4;
            Colors = new[] { a, b, c, d };
        }
    }
}