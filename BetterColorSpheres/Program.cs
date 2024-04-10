using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some spheres
            Sphere sphere1 = new Sphere(150, 50);
            Sphere sphere2 = new Sphere(50, 75);
            Sphere sphere3 = new Sphere(0, 100);

            // Throw the spheres back and forth
            sphere1.Throw();
            sphere2.Throw();
            sphere3.Throw();

            // Pop one or more spheres
            sphere1.Pop();

            // Print the state of the spheres
            Console.WriteLine($"Sphere 1: Color = {sphere1.cor}, Raio =" + 
            $"{sphere1.raio}, times thrown = {sphere1.GetTimesThrown()}");
            Console.WriteLine($"Sphere 1: Color = {sphere2.cor}, Raio =" + 
            $"{sphere2.raio}, times thrown = {sphere2.GetTimesThrown()}");
            Console.WriteLine($"Sphere 1: Color = {sphere3.cor}, Raio =" + 
            $"{sphere3.raio}, times thrown = {sphere3.GetTimesThrown()}");
        }
    }
}