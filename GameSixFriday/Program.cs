using System;

namespace GameSixFriday
{
    
    public class Program
    {
        private static void Main()
        {
            GameLevel gl = new GameLevel(15, Difficulty.Hard);

            gl.SetEnemyInRoom(2, new Enemy("Darth Vader"));
            gl.SetEnemyInRoom(5, new Enemy("Borg Queen"));
            gl.SetEnemyInRoom(11, new Enemy("Thanos"));
            gl.SetEnemyInRoom(12, new Enemy("Xenomorph"));

            Console.WriteLine($"Difficulty: {gl.GetDifficulty()}");

            Console.WriteLine($"Number of rooms: {gl.GetNumRooms()}");

            Console.WriteLine($"Number of foes: {gl.GetNumFoes()}");

            gl.PrintEnemies();

            // Este programa mostra o seguinte no ecrã:
            //
            // Difficulty: Hard
            // Number of rooms: 15
            // Number of foes: 4
            // Room 2: Darth Vader
            // Room 5: Borg Queen
            // Room 11: Thanos
            // Room 12: Xenomorph
        }
    }
}
