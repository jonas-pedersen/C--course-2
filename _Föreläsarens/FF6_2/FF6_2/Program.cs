using System;

namespace FF6_2
{
    public class Person
    {
        public string Namn;
        public int Ålder;
        public string Favoritfärg;
        public bool Gift;

        public Person(string n, int å, string ff, bool g)
        {
            Namn = n;
            Ålder = å;
            Favoritfärg = ff;
            Gift = g;
        }

        public string Beskrivning()
        {
            return $"Hej jag heter {Namn}";
        }
    }


    public class Folksamling
    {
        private Person[] personer;
        private int index = 0;

        public Folksamling()
        {
            personer = new Person[10];
        }

        public void Add(Person p)
        {
            // Lägg till en given person på den interna arrayen
            personer[index] = p;
            index++;
        }

        public int Antal()
        {
            return index;
        }
    }



    public class Program
    {
        public static void GiltigtMenyval(string s)
        {
            if (s == "plus")
            {

            }
            else if (s == "minus")
            {

            }
            // ...
            else
            {
                throw new FormatException("Ogiltigt menyval");
            }
        }

        public static int GetInt(string s)
        {
            int i = int.Parse(s);
            // throw new FormatException();
            return i;
        }

        static void Main(string[] args)
        {
            Folksamling f = new Folksamling();
            Person per = new Person("Marcus", 100, "Blå", false);
            f.Add(per);
            f.Add(new Person("Marcus 2", 200, "Superblå", true));

            // ---
            Console.WriteLine(f.Antal());
            Punkt p = new Punkt(2, 3);

            int xy = p.XplusY();

            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[3];

            // a.CopyTo(b) // använder medlemsmetoden
            // Array.Copy(a, b) // använder klassen Arrays statiska metod

            Console.WriteLine("Hello World!");
        }
    }

    public class Punkt
    {
        public int X; // Fält (field) - en variabel
        public int Y;

        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Punkt Copy()
        {
            return this;
        }

        public int XplusY()
        {
            return X + Y;
        }

        public static Punkt Copy(Punkt p)
        {
            return new Punkt(p.X, p.Y);
        }
    }
}
