using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask number of enemies
            Console.WriteLine("Enter the number of enemies in the game: ");
            int EnemyNum = int.Parse(Console.ReadLine());

            Enemy[] enemies = new Enemy[EnemyNum];

            for (int i = 0; i < EnemyNum; i++)
            {

            }
        }
    }
}
