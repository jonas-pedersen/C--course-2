using System;
using System.Collections.Generic;

namespace FF10
{
    enum Direction { }

    interface IMovable
    {
        public Direction CurrentDirection { get; set; }
    }

    /*
    interface BästaTalet  // IRenderable
    {
        public int Tal { get; }
    }

    class Marcus : BästaTalet
    {
        public int Tal { get { return 42; } }
    }
    class NågonAnnan : BästaTalet
    {
        public int Tal { get => 35; }
    }
    */

    class Person  // T.ex. Player, Food, GameObject
    {
        public string Name;
        public int Age;

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
    }

    class Folksamling  // GameWorld
    {
        private List<Person> personer = new List<Person>();

        public Folksamling()
        {
        }

        public void AddPerson(Person p)
        {
            personer.Add(p);
        }

        public int Antal()
        {
            return personer.Count;
        }

        public int TotalÅlder()
        {
            int summa = 0;
            foreach (Person p in personer)
            {
                summa += p.Age;
            }
            return summa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(20, 20);
            Console.SetBufferSize(20, 20);

            Console.SetCursorPosition(5, 5);
            Console.Write("M");
            Console.SetCursorPosition(10, 10);
            Console.Write("A");
            Console.SetCursorPosition(15, 15);
            Console.Write("R");


            //Folksamling f = new Folksamling();
            //Person m = new Person("Marcus", 100);
            //Person q = new Person("Quention", 25);
            //f.AddPerson(m);
            //f.AddPerson(q);
            //Console.WriteLine(f.TotalÅlder());

            //Marcus m = new Marcus();
            //Console.WriteLine(m.Tal);
        }
    }
}
