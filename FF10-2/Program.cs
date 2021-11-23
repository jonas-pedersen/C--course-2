using System;
using System.Collections.Generic;

namespace FF10_2
{

    //-----Interfaces-exempel-----
    //// Ungefär som - IRenderable - Används för de klasser som har något som de ska skriva ut på skärmen. 
    //// De bör ha en property som beskriver vad det är för tecken eller så som ska ritas upp i konsolen.
    //interface BästaTalet 
    //{
    //    public int Tal { get; }

    //}

    //class Marucs: BästaTalet
    //{
    //    // Properties ser ut som det borde vara en variabel, men det finns två metoder (get och set) bakom, 
    //    // Mha dessa kan jag bestämma vad som händer när jag försöker get eller set. 
    //    // För inlämningsuppgiften så behöver vi bara kunna läsa ifrån IRenderable
    //    public int Tal { get { return 42; } }
    //}

    
    //class NågonAnnan: BästaTalet
    //{
    //    // Man kan implementera samma interface i en annan klass, men låta dens get eller set metod fungera annorlunda
    //    // Tex här returnera ett annat tal. Kan skrivas med pilnotation också. 
    //    public int Tal { get => 35;  }
    //}


    //-----Klass-Samlings-Exempel-----
    class Person  // Kan motsvaras av Player, Food, GameObject-klasserna i Snake. 
    {
        public string Name;
        public int Age;

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
    }


    // Bra att ha en klass med en lista av personer då man kan göra olika metoder som är anpassat för just vår lista (personer som ligger i denna klass)
    // Som vår klass GameWorld i Snake. Dvs man har en samling av Player, Food, GameObject i GameWorld.
    // Efter man samlat de i GameWorld kan vi kontrollera olika logik om man är på maten osv. 
    // Man måste inte skriv in en tom konstruktor för att klassen ska funka. Vi har inget vi vill lägga till när vi skapar 
    // klassen Folksamling. 
    class Folksamling  
    {
        private List<Person> personer = new List<Person>();


        // Konstruktor behöver ej skrivas ut då den ej tillför något. 
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

        // Summerar personers ålder och returnerar den. 
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
            ////-----Interfaces-exempel-----
            //Marucs m = new Marucs();
            //Console.WriteLine(m.Tal);


            ////-----Klass-Samlings-Exempel-----
            //Folksamling f = new Folksamling();
            //Person p1 = new Person("Marcus", 100);
            //Person p2 = new Person("Anders", 25);
            //f.AddPerson(p1);
            //f.AddPerson(p2);
            //Console.WriteLine(f.TotalÅlder());


            //-----Tips inför ConsoleRender-klassen i Snake-----

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(40, 40);

            // Buffer måste vara minst lika stor som vårt window.
            // Grafiken skrivs till Buffern först sedan när allt är buffrat så skrivs det till skärmen. 
            Console.SetBufferSize(40, 40);

            // 0, 0 är högst upp i vänstra hörnet.
            //Console.SetCursorPosition(0, 0);
            //Console.Write("J");

            Console.SetCursorPosition(5, 5);
            Console.Write("M");
            Console.SetCursorPosition(10, 10);
            Console.Write("A");
            Console.SetCursorPosition(15, 15);
            Console.Write("R");

        }
    }
}
