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
                Console.WriteLine("Usage: dotnet run --project MyGame -- <number_of_enemies>");
                return;
            }

            Enemy[] enemies = new Enemy[numberOfEnemies];

            for (int i = 0; i < numberOfEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
            }

            // Simulate collecting power-ups
            enemies[0].PickupPowerUp(PowerUp.Health, 20); // enemy1 collects hpu
            enemies[1].PickupPowerUp(PowerUp.Shield, 30); // enemy2 collects spu

            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }

            // Display total power-ups collected
            Console.WriteLine($"Total Power-Ups Collected: {Enemy.GetTotalPowerUpsCollected()}");
        }
    }
}