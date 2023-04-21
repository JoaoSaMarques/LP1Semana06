using System;

namespace GameSixFriday
{
    public class GameLevel
    {

        private int numRooms;
        private string difficulty;
        private Enemy[] foes;

        public GameLevel(int numRooms, string difficulty)
        {
            this.numRooms = numRooms;
            this.difficulty = difficulty;
            foes = new Enemy[numRooms];
        }
        
        public void SetEnemyInRoom(int roomIndex, Enemy foe)
        {
            if (roomIndex < 0 || roomIndex >= numRooms)
            {
                throw new ArgumentException("Invalid room index");
            }

            foes[roomIndex] = foe;
        }

        public GameLevel(int v, Difficulty hard)
        {
            this.v = v;
            this.hard = hard;
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


