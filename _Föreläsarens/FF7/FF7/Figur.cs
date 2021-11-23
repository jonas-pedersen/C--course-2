using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    class Figur: object
    {
        public double Something;

        public virtual double Area() { return 0; }

        public virtual void Hello() { Console.WriteLine("Hello"); }
    }
}
