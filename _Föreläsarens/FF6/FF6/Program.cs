using System;

namespace FF6
{
    class Program
    {
        static void IncreaseXByFive(Punkt q)
        {
            q.X += 5;
        }

        static void SetFirstNumberTo100(int[] a)
        {
            a[0] = 100;
        }
 
        static Punkt GetNewPoint()
        {
            try
            {
                Console.WriteLine("Enter X and Y coordinates:");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                return new Punkt(x, y);
            }
            catch (FormatException)
            {
                return null;
            }
        }

        static int GetNumber()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int x = int.Parse(Console.ReadLine());
                return x;
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        static bool? IsItRaining()
        {
            try
            {
                // Någon smart logik som läser av en sensor

                return true; // eller false
            }
            catch (Exception)  // nätverksfel
            {
                return null;
            }
        }

        static void IncreaseByFive(int i)
        {
            i += 5;
        }

        static void IncreaseByFiveRef(ref int i)
        {
            i += 5;
        }
        static int IncreaseByFiveAlt(int i)
        {
            i += 5;
            return i;
        }

        static void IncreaseByFiveOut(out int i)
        {
            i = 5;
        }

        static void Main(string[] args)
        {
            int x = 100;
            IncreaseByFive(x);
            IncreaseByFiveRef(ref x);
            x = IncreaseByFiveAlt(x);
            Console.WriteLine(x);

            IncreaseByFiveOut(out int y);
            Console.WriteLine(y);

            /*
            int? i = GetNumber();

            if (i == null)
            {
                Console.WriteLine("Inget tal :(");
            }
            else
            {
                Console.WriteLine(i);
            }


            Punkt p = GetNewPoint();

            Console.WriteLine(p?.X);  // null check operator

            if (p != null)
            {
                Console.WriteLine(p.X);
            }
            */

            /*
            Punkt p = null;

           // p.X = 3;
           // p.Y = 7;

            Punkt q = p.Copy();

            // ...

            p = new Punkt(2, 3);

            p = new Punkt(5, 7);
            */


            /*
            string s = "Det här är ju kanske väldigt långt!";
            Console.WriteLine(s[0]);

            const int y = 300;
            int x = 10;
            IncreaseByFive(x);
            Console.WriteLine(x);

            Punkt p = new Punkt(10, 10);
            IncreaseXByFive(p);
            Console.WriteLine(p.X);

            Punkt p2 = new Punkt(p.X, p.Y);
            Punkt p3 = p.Copy();

            int[] array = new int[] { 2, 3, 4 };
            int[] arrayCopy = new int[3];

            Array.Copy(array, arrayCopy, 3);



            SetFirstNumberTo100(array);
            Console.WriteLine(array[0]);



            /*
            // Samma med float, double, string, long, bool, etc.
            // Värdetyper (value types)
            // Gör kopior av värden
            int x = 10;
            int y = x;
            x = 20;
            Console.WriteLine(y);


            // Alla "mer" komplicerade objekt, arrayer, alla våra egna klasser, etc.
            // Referenstyper (reference types)
            Punkt p = new Punkt(2, 3);
            Punkt q = p;
            Punkt r = q;
            p.X = 80;
            Console.WriteLine(q.X);
            */
        }
    }
}
