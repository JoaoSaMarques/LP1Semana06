using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask number of enemies
            Console.WriteLine("Enter the number of enemies in the game: ");
            //Convert string to int
            int EnemyNum = int.Parse(Console.ReadLine());

            //Enemy number list
            Enemy[] enemies = new Enemy[EnemyNum];

            //For i
            for (int i = 0; i < EnemyNum; i++)
            {
                //Every i enter a name and then +1 until it reaches EnemyNum
                Console.Write($"Enter the name of enemy #{i+1}: ");
                //Enter name of enemy
                string name = Console.ReadLine();
                
                //Create new enemy with name
                Enemy foe = new Enemy(name);
                //Enemies = foe
                enemies[i] = foe;
            }

            //Tells you the enemies' names
            Console.WriteLine("Enemy Names:");
        }
    }
}
