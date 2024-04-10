using System;

namespace ColorSpheres
{
    public class Color
    {
        public int Red { get; private set; }
        public int Blue { get; private set; }
        public int Green { get; private set; }
        public readonly int Alpha;

        public Color(int red, int blue, int green, int alpha)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = alpha;
        }

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }

        public const int MAX_COLOR_VALUE = 255;
    }
}
