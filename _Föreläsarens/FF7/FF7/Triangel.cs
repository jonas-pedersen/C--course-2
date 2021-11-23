using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    class Triangel: Figur
    {
        public double Bas, Höjd;

        public Triangel(double b, double h)
        {
            Bas = b;
            Höjd = h;
        }

        public override double Area()
        {
            return Bas * Höjd / 2.0;
        }
    }
}
