using System;

namespace FF2_2
{

    class Program
    {

        // 1. Skriv en (void) funktion som tar några argument av olika typer 
        // (int, float, bool, string, etc.) och skriver ut samtliga till konsollen.

        static void Uppg1 (int x, float y, string z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine($"{x}, {y}, {z}");
        }

        // 3. Skriv en funktion som tar ett tal n som argument och returnerar strängen 
        // "stort" om talet är större än 100, "litet" om talet är mellan 0 och 100, och annars "negativt".

        static string Uppg3(int n)
        {
            if (n > 100)
            {
                return "stort";
            }
            else if (n >= 0)
            {
                return "litet";
            }
            else
            {
                return "negativt";
            }
        }

        // 4. Skriv en funktion som tar ett tal n som argument och returnerar 
        // summan av alla tal från 1 till n.
        static int Uppg4(int n)
        {
            int summa = 0;
            for (int i = 1; i <= n; i++)
            {
                summa += i;
            }
            return summa;
        }


        // 5. Skriv en funktion som tar två tal som argument och returnerar det största av dem. 
        // Skriv en funktion som gör samma sak fast för tre argument.
        static int Uppg5(int a, int b)
        {

            Console.WriteLine(a > b ? "a större än b" : "a mindre än b");

            return a > b ? a : b;  // Elvis-operator eller ternary operator
            // (statement) ? (true) : (false)

            //Console.WriteLine(a > b ? "a större än b" : "a mindre än b");

            //if (a > b)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}
        }


        //static int Uppg5b (int a, int b, int c)
        //{
        //    int AB = Uppg5(a, b);
        //    int ABC = Uppg5(AB, c);
        //    return ABC;
        //}

        static int Uppg4b(int n) => n * (n + 1) / 2;

        static void Main(string[] args)
        {
            //Uppg1(2, 3.5f, "hejsan");
            Console.WriteLine(Uppg3(15));
            //Console.WriteLine(Uppg4(10));
            //Console.WriteLine(Uppg4b(10));
            Console.WriteLine(Uppg5(6, 15));
            //Console.WriteLine(Uppg5b(25, 12, 17));
        }
    }
}
