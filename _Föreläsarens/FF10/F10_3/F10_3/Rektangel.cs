using System;
using System.Collections.Generic;
using System.Text;

namespace F10_3
{
    class Rektangel<T> where T: struct
    {
        public T Bredd;
        public T Höjd;

        public Rektangel(T sida)
        {
            Bredd = sida;
            Höjd = sida;
        }

        public Rektangel(T bredd, T höjd)
        {
            Bredd = bredd;
            Höjd = höjd;
        }

        // Det här funkar inte, alla structar har inte *
        // public T Area() => Bredd * Höjd;

        public T Area()
        {
        // Så hur kan vi göra detta?
        // Använd "dynamic". Se det andra svaret här:
        // https://stackoverflow.com/questions/10951392/implementing-arithmetic-in-generics

            return T();
        }
    }
}
