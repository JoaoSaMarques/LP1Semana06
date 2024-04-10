    using System;

    namespace BetterColorSpheres
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create some spheres
                Sphere sphere1 = new Sphere(new Color(150, 0, 0, 255), 50);
                Sphere sphere2 = new Sphere(new Color(0, 150, 0, 255), 75);
                Sphere sphere3 = new Sphere(new Color(0, 0, 150, 255), 100);

                // Throw the spheres back and forth
                sphere1.Throw();
                sphere2.Throw();
                sphere3.Throw();

                // Pop one or more spheres
                sphere1.Pop();

                // Print the state of the spheres
                Console.WriteLine($"Sphere 1: Color = {sphere1.Cor}, Raio = " + 
                $"{sphere1.Raio}, times thrown = {sphere1.GetTimesThrown()}");
                Console.WriteLine($"Sphere 1: Color = {sphere2.Cor}, Raio = " + 
                $"{sphere2.Raio}, times thrown = {sphere2.GetTimesThrown()}");
                Console.WriteLine($"Sphere 1: Color = {sphere3.Cor}, Raio = " + 
                $"{sphere3.Raio}, times thrown = {sphere3.GetTimesThrown()}");
            }
        }
    }