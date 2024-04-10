using System;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

namespace BetterColorSpheres
{
    public class Sphere 
    {
        public int cor { get; set; }
        public float raio { get; set; }
        public int numberoftimesthrown { get; set; }

        public Sphere(int cor, float raio)
        {
            this.cor = cor;
            this.raio = raio;
            this.numberoftimesthrown = 0;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if (raio > 0)
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
