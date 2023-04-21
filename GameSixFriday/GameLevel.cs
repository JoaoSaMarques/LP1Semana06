using System;

namespace GameSixFriday
{
    public class GameLevel
    {
        //NumRooms is an int
        private int numRooms;
        //Difficulty is a string
        private Difficulty difficulty;
        //List Enemy
        private Enemy[] enemies;

        //Constructor
        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.numRooms = numRooms;
            this.difficulty = difficulty;
            enemies = new Enemy[numRooms];
        }
        
        //Set enemies into the room
        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            if (roomIndex < 0 || roomIndex >= numRooms)
            {
                throw new ArgumentException("Invalid room index");
            }

            enemies[roomIndex] = enemy;
        }

        public float GetNumRooms()
        {
            return numRooms;
        }

        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        public int GetNumFoes()
        {
            int count = 0;
            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < numRooms; i++)
            {
                if (enemies[i] != null)
                {
                    Console.WriteLine($"Room {i}: {enemies[i].GetName()}");
                }
            }
        }
    }
}


