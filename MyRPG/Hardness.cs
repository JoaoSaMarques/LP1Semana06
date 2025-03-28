using System;

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
        public int Level;
        public Hardness Hardness;
    }

    public void SetEnemyInRoom(int roomIndex, Enemy enemy)
    {
        if (roomIndex < 0 || roomIndex >= numberOfRooms)
        {
            throw new ArgumentOutOfRangeException(nameof(roomIndex), "Room index is out of range.");
        }
        enemiesInRooms[roomIndex] = enemy;
    }
}