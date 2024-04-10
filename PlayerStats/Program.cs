using System;

namespace PlayerStats
{
    public class Player
    {
        public float highScore;
        public int playedGames;
        public int wonGames;
        
        public float HighScore
        {
            get { return highScore; }
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

    }
}
