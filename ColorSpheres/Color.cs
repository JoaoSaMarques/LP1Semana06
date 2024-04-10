using System;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

namespace ColorSpheres
{
    public class Color
    {
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }

        public Color(int red, int blue, int green, int alpha)
        {
            Red = red;
            Blue = blue;
            Green = green;
            alpha = 255;
        }

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
