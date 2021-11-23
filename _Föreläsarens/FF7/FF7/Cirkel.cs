using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    class Cirkel: Figur
    {
        public double Radie;

        public Cirkel(double r)
        {
            Radie = r;
        }

        public override double Area()
        {
            return Radie * Radie * Math.PI;
        }

        public override void Hello()
        {
            base.Hello();
            Console.WriteLine("Hej, jag är en cirkel.");
        }

        public override string ToString()
        {
            return $"Cirkel med radien {Radie}.";
        }
    }
}
