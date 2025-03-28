using System;

namespace MyRPG
{
    public enum Hardness
    {
        Easy,
        Normal,

        Hard
        
    }

    public class GameLevel
    {
        public int Level;
        public Hardness Hardness;
    }
}