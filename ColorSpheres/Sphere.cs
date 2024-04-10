using System;

namespace ColorSpheres
{
    public class Sphere 
    {
        public int Cor { get; set; }
        public float Raio { get; set; }
        public int numberoftimesthrown { get; set; }

        public Sphere(int cor, float raio)
        {
            Cor = cor;
            Raio = raio;
            numberoftimesthrown = 0;
        }

        public void Pop()
        {
            Raio = 0;
        }

        public void Throw()
        {
            if (Raio > 0)
            {
                numberoftimesthrown += 1;
            }
        }

        public int GetTimesThrown()
        {
            return numberoftimesthrown;
        }
    }
}
