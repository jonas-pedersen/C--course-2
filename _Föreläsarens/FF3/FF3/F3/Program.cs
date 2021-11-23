using System;

namespace F3
{
    class Program
    {
        static string Weekday(int n)
        {
            switch (n)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    Console.WriteLine("Bad argument!");
                    return "";
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Skriv ett tal 1-7");
                int tal = int.Parse(Console.ReadLine());
                Console.WriteLine(Weekday(tal));
            }
            catch (FormatException)
            {
                Console.WriteLine("Inkorrekt inmatning!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("There is no such weekday.");
            }

            /*Console.WriteLine("Vad är ditt favorittal?");
            string input = Console.ReadLine();
            int favorittal;

            try
            {
                favorittal = int.Parse(input);
            }
            catch (FormatException Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.WriteLine("Det där var inget riktigt tal. Du får 25 istället.");
                favorittal = 25;
            }

            Console.WriteLine($"Dubbla favorittalet är {favorittal * 2}");
            */
        }
    }
}
