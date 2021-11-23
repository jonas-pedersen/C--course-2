using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    // Betyder att klassen Triangel ärver av klassen Figur.
    class Triangel: Figur
    {
        public double Bas, Höjd;

        public Triangel(double b, double h)
        {
            Bas = b;
            Höjd = h;
        }


        // Denna Area-metod används istället för moderns Area-metod då den här har override.
        public override double Area()
        {
            return Bas * Höjd / 2;
        }

    }
}
