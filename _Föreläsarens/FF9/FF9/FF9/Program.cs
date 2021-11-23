using System;

namespace FF9
{
    class Person
    {

    }

    class Punkt<Type> where Type: struct
    {
        public Type X, Y;

        public Punkt(Type x, Type y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static T Största<T>(T a, T b) where T : IComparable
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            Punkt<int> p = new Punkt<int>(2, 3);
            Console.WriteLine(p.X);

            Punkt<float> p2 = new Punkt<float>(2.0f, 3.0f);
            Console.WriteLine(p2.X);


            // Funkar fint :)
            int störst = Största<int>(3, 5);
            float störst2 = Största<float>(3.0f, 5.0f);
            double störst3 = Största<double>(3.0, 5.0);

            // Inte tillåtet :)
            // Punkt störstapunkten = Största(new Punkt(1, 2), new Punkt(3, 4));
        }
    }
}
