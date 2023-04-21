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

        public float GetNumRooms()
        {
            return numRooms;
        }

        public string GetDifficulty()
        {
            return difficulty;
        }

        public int GetNumFoes()
        {
            int count = 0;
            foreach (Enemy foe in foes)
            {
                if (foe != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}


