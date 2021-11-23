using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    class Figur
    {
        public double Something;

        // Man kan ha base i konstruktorn. Kommer på nästa föreläsning.

        public virtual double Area()
        {
            return 0;
        }

        public virtual void Hello()
        {
            Console.WriteLine("Hello!");
        }


    }
}
