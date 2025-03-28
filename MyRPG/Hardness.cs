using System;
using System.Collections.Generic;
using Humanizer; // Ensure you have the Humanizer library installed

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
        private int numberOfRooms;
        private Hardness difficulty;
        private List<Enemy> enemiesInRooms;

        public GameLevel(int numberOfRooms, Hardness difficulty)
        {
            this.numberOfRooms = numberOfRooms;
            this.difficulty = difficulty;
            this.enemiesInRooms = new List<Enemy>(new Enemy[numberOfRooms]);
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            if (roomIndex < 0 || roomIndex >= numberOfRooms)
            {
                throw new ArgumentOutOfRangeException(nameof(roomIndex), "Room index is out of range.");
            }
            enemiesInRooms[roomIndex] = enemy;
        }

        public Hardness GetHardness()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return numberOfRooms;
        }

        public int GetNumEnemies()
        {
            int count = 0;
            foreach (var enemy in enemiesInRooms)
            {
                if (enemy != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}