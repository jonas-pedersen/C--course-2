using System;
using System.Collections.Generic;
using System.Text;

namespace F10_3
{
    class Wrapper<T> where T: struct
    {
        private T? value;

        public Wrapper()
        {
            value = null;
        }

        public Wrapper(T v)
        {
            value = v;
        }

        public void Show()
        {
            if (value == null)
            {
                Console.WriteLine("Inget");
            }
            else
            {
                Console.WriteLine(value);
            }
        }

        public void Set(T newvalue)
        {
            value = newvalue;
        }
    }
}
