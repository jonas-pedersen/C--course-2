using System;

namespace FF3
{
    class Program
    {
        //// --Exempel 1 Weekday()--
        //static string Weekday(int n)
        //{
        //    switch (n)
        //    {
        //        case 1:
        //            return "Monday";
        //        case 2:
        //            return "Tuesday";
        //        case 3:
        //            return "Wednesday";
        //        case 4:
        //            return "Thursday";
        //        case 5:
        //            return "Friday";
        //        case 6:
        //            return "Saturday";
        //        case 7:
        //            return "Sunday";
        //        default:
        //            throw new ArgumentException("The input argument must be between 1 - 7");
        //    }
        //}

        // Exempel 2 Weekday()--
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
            // ----Hantera fel----

            // Ger fel då det blir för stort fönster. Ger Exception. 
            //Console.SetWindowSize(300, 300);

            // --Exempel 2 med Weekday() och try catch--
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



            // --Exempel 1 med Weekday() och try catch--
            //try
            //{
            //    Console.WriteLine(Weekday(8));
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("There is no such weekday");
            //}


            // --Exempel Favorit tal--
            // --Gör en try catch för att visa hur man kan hantera fel--
            Console.WriteLine("Vad är ditt favorittal?");
            string input = Console.ReadLine();
            int favorittal;

            try
            {
                favorittal = int.Parse(input);
            }
            catch (FormatException Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.WriteLine("Det där var inget riktigt tal. Du får 25 istället");
                favorittal = 25;
            }

            Console.WriteLine($"Dubbla favorittalet är {favorittal * 2}");


        }
    }
}
