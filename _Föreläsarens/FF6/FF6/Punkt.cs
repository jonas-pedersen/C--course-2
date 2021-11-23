using System;
using System.Collections.Generic;
using System.Text;

namespace FF6
{
    class Punkt
    {
        public int X;
        public int Y;
        public Punkt p;

        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Punkt Copy()
        {
            return new Punkt(X, Y);
        }
    }
}
