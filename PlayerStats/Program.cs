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

        public readonly string Name;

        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0;
                }
                else
                {
                    return (float)wonGames / playedGames;
                }
            }
        }

    }
}
