using System;

namespace ColorSpheres
{
    public class Color
    {
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }

        public Color(int red, int blue, int green)
        {
            Red = red;
            Blue = blue;
            Green = green;
        }
    }
}
