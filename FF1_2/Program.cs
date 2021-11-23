using System;

namespace FFJonas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int tal = 23;  // Är 4 byte stor
            long storaTal = 123456789;  // Är 8 byte stor

            float flyttal = 23.0f;
            double dubblaFlyttal = 23.0;  // Den fattar att det är en double även utan d på slutet. Default är double

            char letter = 'J';
            string text = "Hejsan";

            bool isTuesday = true;

            Console.WriteLine(text + " Jag heter Jonas. Mitt favoritnummer är " + tal);
            // Effektivare än ovan
            Console.WriteLine($"{text} Jag heter Jonas. Mitt favoritnummer är {tal}");

            string[] names = new string[] {"Jonas", "Daniel", "Jonatan" };
            int[] ages = new int[] { 99, 88, 77 };

            Console.WriteLine( names[0] ); // Skriva ut en sak ifrån arrayen

            // Skriva ut med for-loop
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            // Skriva ut med while-loop
            //int i = 0;
            //while (i < names.Length)
            //{
            //    Console.WriteLine(names[i]);
            //    i++;
            //}

            // Skriva ut med foreach
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
