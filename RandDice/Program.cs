using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.Write("<number_of_dice> <seed>");
                return;
            }

            int numberOfDice = int.Parse(args[0]);
            int seed = int.Parse(args[1]);
            Random random = new Random(seed);
            int sum = 0;

            for (int i = 0; i < numberOfDice; i++)
            {
                sum += random.Next(1, 7); // Generates a number between 1 and 6
            }
        }
    }
}
