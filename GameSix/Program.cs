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
            Foe[] enemies = new Foe[EnemyNum];

            //For i
            for (int i = 0; i < EnemyNum; i++)
            {
                //Every i enter a name and then +1 until it reaches EnemyNum
                Console.Write($"Enter the name of enemy #{i+1}: ");
                //Enter name of enemy
                string name = Console.ReadLine();
                
                //Create new enemy with name
                Foe foe = new Foe(name);
                //Enemies = foe
                enemies[i] = foe;
            }

            //Tells you the enemies' names
            Console.WriteLine("\nEnemy Names: ");
            //For each enemy in the list
            foreach (Foe enemy in enemies)
            {
                //Get enemy name and return it
                Console.WriteLine(enemy.GetName());
            }

            //Test method
            //Make Goblin enemy
            Foe Goblin = new Foe("Goblin");
            //Get goblin's name
            Console.WriteLine($"\nDefault name: {Goblin.GetName()}");
            //Print initial Health
            Console.WriteLine($"IHealth: {Goblin.GetHealth()}");//should be 100
            //Print initial shield
            Console.WriteLine($"IShield: {Goblin.GetShield()}");//should be 0

            //Make enemy pickup the powerup for health
            Goblin.PickupPowerUp(PowerUp.Health, 20);
            //Write health after powerup
            Console.WriteLine($"\nHealth powerup: {Goblin.GetHealth()}");
            //Write shield after powerup
            Console.WriteLine($"Shield powerup: {Goblin.GetShield()}");

            //Take 20 damage
            Goblin.TakeDamage(20);
            //Print health after damage
            Console.WriteLine($"\nDHealth: {Goblin.GetHealth()}");//should be 80
            //Print shield after damage
            Console.WriteLine($"DShield: {Goblin.GetShield()}");//should be 0

            //Number of powerups collected
            int powerUpCount = Foe.GetPowerUpCount();
            Console.WriteLine($"\nPowerup count: {powerUpCount}");//Should be 1


            Console.WriteLine("Thank you for using the program!");

        }
            
    }
}
