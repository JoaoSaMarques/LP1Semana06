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
        private Foe[] foes;

        //Constructor
        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.numRooms = numRooms;
            this.difficulty = difficulty;
            foes = new Foe[numRooms];
        }
        
        //Set enemies into the room
        public void SetFoeInRoom(int roomIndex, Foe foe)
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

        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        public int GetNumFoes()
        {
            int count = 0;
            foreach (Foe foe in foes)
            {
                if (foe != null)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintFoes()
        {
            for (int i = 0; i < numRooms; i++)
            {
                if (foes[i] != null)
                {
                    Console.WriteLine($"Room {i}: {foes[i].GetName()}");
                }
            }
        }
    }
}


