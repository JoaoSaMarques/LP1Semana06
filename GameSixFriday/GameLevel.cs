using System;

namespace GameSixFriday
{
    public class GameLevel
    {

        private float RoomNumber;
        private String Difficulty;


    
        //Constructor
        public GameLevel(string Difficulty)
        {
            this.Difficulty = Difficulty;
            RoomNumber = 0;
        }

        public float GetNumRooms()
        {
            return RoomNumber;
        }
    }
}


