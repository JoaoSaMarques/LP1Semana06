using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some spheres
            Sphere sphere1 = new Sphere(255, 50);
            Sphere sphere2 = new Sphere(128, 75);
            Sphere sphere3 = new Sphere(0, 100);

            // Throw the spheres back and forth
            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();

            // Pop one or more spheres
            sphere1.Pop();

            // Print the state of the spheres
            Console.WriteLine($@"Sphere 1: {sphere1.cor}, {sphere1.raio},
            {sphere1.GetTimesThrown()}");
            Console.WriteLine($@"Sphere 2: {sphere2.cor}, {sphere2.raio},
            {sphere2.GetTimesThrown()}");
            Console.WriteLine($@"Sphere 3: {sphere3.cor}, {sphere3.raio},
            {sphere3.GetTimesThrown()}");

            // Wait for user input before closing the program
            Console.ReadLine();
        }
    }
}