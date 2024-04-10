using System;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Cor { get; set; }
        public float Raio { get; set; }
        public int Numberoftimesthrown { get; private set; }

        public Sphere(Color cor, float raio)
        {
            Cor = cor;
            Raio = raio;
            Numberoftimesthrown = 0;
        }

        public void Pop()
        {
            Raio = 0;
        }

        public void Throw()
        {
            if (Raio > 0)
            {
                Numberoftimesthrown += 1;
            }
        }

        public int GetTimesThrown()
        {
            return Numberoftimesthrown;
        }
    }
}

