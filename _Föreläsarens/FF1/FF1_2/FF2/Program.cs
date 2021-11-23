using System;

namespace FF2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 23;
            long storaTal = 123456789;

            float flyttal = 23.0f;
            double dubblaFlyttal = 23.0d;

            char letter = 'H';
            string text = "Hejsan!";

            bool isTuesday = true;

            Console.WriteLine(text + " Jag heter marcus. Mitt favoritnummer är " + tal);
            Console.WriteLine($"{text} Jag heter marcus. Mitt favoritnummer är {tal}"); // Effektivare

            string[] names = new string[] { "marcus", "daniel", "jonathan" };
            int[] ages = new int[] { 99, 88, 77 };

            // Alla dessa loopar är lika:

            /*
            for (int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            /*int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }*/
        }
    }
}
