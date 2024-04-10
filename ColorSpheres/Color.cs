using System;

namespace ColorSpheres
{
    public class Color
    {
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
        public int Alpha { get; set; }

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
    }
}
