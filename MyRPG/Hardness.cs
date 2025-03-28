using System;
using System.Collections.Generic;
using Humanizer;

namespace MyRPG
{
    // Enum
    public enum Hardness
    {
        Easy,
        Normal,
        Hard
    }

    // Constructor
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

        // Puts enemies inside a room
        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            if (roomIndex < 0 || roomIndex >= numberOfRooms)
            {
                throw new ArgumentOutOfRangeException(nameof(roomIndex), "Room index is out of range.");
            }
            enemiesInRooms[roomIndex] = enemy;
        }

        // Get the difficulty of a room
        public Hardness GetHardness()
        {
            return difficulty;
        }

        // Get the number of rooms present
        public int GetNumRooms()
        {
            return numberOfRooms;
        }

        // Get the number of enemies present in an array
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

        // Show enemies in a room
        public void PrintEnemies()
        {
            for (int i = 0; i < enemiesInRooms.Count; i++)
            {
                if (enemiesInRooms[i] != null)
                {
                    Console.WriteLine($"Room {i.ToRoman()}: {enemiesInRooms[i].GetName()}");


                }
            }
        }
    }
}