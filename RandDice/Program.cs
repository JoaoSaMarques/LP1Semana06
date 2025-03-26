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
        }
    }
}
