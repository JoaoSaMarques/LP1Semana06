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
        }
    }
}
