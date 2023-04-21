using System;

namespace GameSixFriday
{
    public class GameLevel
    {

        private float RoomNumber;
        private String Difficulty;
        private float NumFoes;


    
        //Constructor
        public GameLevel(string Difficulty)
        {
            this.Difficulty = Difficulty;
            RoomNumber = 0;
            NumFoes = 0;
        }

        public float GetNumRooms()
        {
            return RoomNumber;
        }

        public string GetDifficulty()
        {
            return Difficulty;
        }

        public float GetNumFoes()
        {
            return NumFoes;
        }
    }
}


