using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1 || !int.TryParse(args[0], 
            out int numberOfEnemies) || numberOfEnemies <= 0)
            {
                Console.Write("<number_of_enemies>");
                return;
            }

            Enemy[] enemies = new Enemy[numberOfEnemies];

            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
            }

            Console.WriteLine("Inimigos:");
            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
        }
    }
}
