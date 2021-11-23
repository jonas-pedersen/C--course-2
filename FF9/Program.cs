using System;
using System.Collections.Generic;

namespace FF9
{
    // ----Generisk klass för Punkter av alla olika typer----
    class Punkt<Type> where Type: struct
    {
        public Type X, Y;
        public Punkt(Type x, Type y)
        {
            X = x;
            Y = y;
        }


        public Type GetX() => X;
    }

    // ----Inte generiskt, Gammalt sätt med en Punkt-klass för varje typ av punkt----
    //class IntPunkt
    //{
    //    int X, Y;
    //    public IntPunkt(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}

    //class FloatPunkt
    //{
    //    float X, Y;
    //    public FloatPunkt(float x, float y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}


    class Program
    {
        // ----Inte generiskt, Gammalt sätt med en Punkt-klass för varje typ av punkt----
        // --Behöver då en metod för varje typ också--
        static int StörstaI(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // För floats annars samma som ovan. 
        static int StörstaF(float c, float d)
        {
            if (c > d)
            {
                return c;
            }
            else
            {
                return d;
            }
        }


        //----Med Generiska typer T----
        static T Största<T>(T a, T b) where T: IComparable
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
            List<string> historik = new List<string>() { };

            // ---Exempel där metoderna INTE tar generiska typer---
            //int störst = StörstaI(3, 5);
            //float största2 = StörstaF(3.0f, 5.0f);
            //// -Nedan funkar inte då det inte finns någon metod som tar in double-
            //double största3 = StörstaI(5.4d, 45d);

            // ---Exempel där metoderna tar generiska typer
            // Tillåtet. Går bara att anropa de som har CompareTo metoden.
            int störst4 = Största<int>(3, 5);
            float största5 = Största<float>(3.0f, 5.0f);


            // ---Exempel med Punkt som tar generiska typer---

            //// Inte tillåtet om man inte skriver en CompareTo-metod till Punkten.
            //Punkt störstaPunkten = Största(new Punkt(1, 2), new Punkt(3, 4));

            //// --Funkar fint då Punkt-klassen tar generiska typer--
            //Punkt<int> p = new Punkt<int>(2, 3);
            //Console.WriteLine(p.X);

            //Punkt<float> p2 = new Punkt<float>(3.1f, 2.4f);
            //Console.WriteLine(p2.X);

        }



    }
}
