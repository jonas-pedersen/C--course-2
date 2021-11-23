using System;
using System.Collections.Generic;

namespace F10_3
{
    /*
     * 1. Återskapa klassen Rektangel från förut utan några metoder (utöver konstruktor). 
     * erbjud möjligheten att välja vilka typer som X och Y ska vara (t.ex. int, float, double?) 
     * med hjälp av generics. Man ska alltså kunna göra t.ex. såhär:

    var P = new Rektangel<int>(2, 3);
    var Q = new Rektangel<double>(2.0, 3.0);

    2. Skapa en metod Show i din Program-klass som tar ett argument av generisk typ. 
    Om typen är int, skriv ut "heltal". Annars anropa objektets ToString() metod (finns alltid), 
    och skriv ut resultatet i konsollen. Testa att anropa Show med några olika variabeltyper.

    3. Skapa en klass Wrapper som beror på en generisk typ T och innehåller en privat variabel av typen T? 
    med namnet value. Visual Studio kommer anmärka på att T lite för generell typ. 
    Låt oss begränsa den till att bara acceptera olika structar genom att lägga till "where T: struct" 
    efter klassnamnet. Skapa en konstruktor som tar ett argument av T och lägger den till value. 

    4. Skapa sedan en konstruktor som inte tar några argument och istället sätter value till null;.
    Skapa en metod Show() som, ifall value är null skriver ut "Inget" och annars skriver ut value. 
    Skapa en metod Set(T newvalue) som byter ut value mot argumentet. Skapa också en metod Reset() 
    som sätter value till null;
    */
    class Program
    {
        static void Show<T>(T value)
        {
            // if (value.GetType() == 1.GetType())
            if (value is int)
            {
                Console.WriteLine("Heltal");
            }
            else if (value is Rektangel<int>)
            {
                Console.WriteLine("Snygg rektangel");
            }
            else
            {
                Console.WriteLine(value.ToString());
            }
        }


        static void Main(string[] args)
        {
            /*
            var P = new Rektangel<int>(2, 3);
            var Q = new Rektangel<double>(2.0, 3.0);
            var R = new Rektangel<string>("abc", "def");

            Show(5);
            Show("abc");
            Show(P);
            */

            Wrapper<int> a = new Wrapper<int>(5);
            Wrapper<double> b = new Wrapper<double>();

            a.Show();
            b.Show();

            b.Set(100.0);
            b.Show();
        }
    }
}
