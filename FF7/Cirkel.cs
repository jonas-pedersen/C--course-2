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

        // Keyword base används för att den kör basens (moderns) metod som heter Hello() och sedan fortsätter
        // med Cirkels variant av Hello()
        public override void Hello()
        {
            base.Hello();
            Console.WriteLine("Hej jag är en Cirkel!");
        }

        public override string ToString()
        {
            return $"Cirkel med radien {Radie}.";
        }

    }
}
