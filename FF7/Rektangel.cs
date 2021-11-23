using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    class Rektangel: Figur
    {
        public double Bredd, Höjd;

        public Rektangel(double b, double h)
        {
            Bredd = b;
            Höjd = h;
        }

        public override double Area()
        {
            return Bredd * Höjd;
        }

    }
}
