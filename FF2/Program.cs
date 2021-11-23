using System;

namespace FF2
{
    class Program
    {
        // Alla metoder kommer åt denna variabel.
        static int x = 3;

        static int addera(int tal1, int tal2 = 5)
        {
            int summa = tal1 + tal2;
            return summa;
        }

        //static int addera(int tal1, int tal2) => tal1 + tal2;

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

                    // Default  är samma som else-blocket i if-satser.
                default:
                    throw new ArgumentException("The input argument must be between 1 and 7");
                    //return "Not a real day!";

            }
        }

        static void Main(string[] args)
        {
            //int resultat = addera(5, 10);
            //Console.WriteLine(resultat);


            // Med try-catch
            try
            {
                Console.WriteLine("Skriv ett tal mellan 1 och 7");
                int tal = int.Parse(Console.ReadLine());
                Console.WriteLine(Weekday(tal));
            }
            catch (FormatException)
            {
                Console.WriteLine("Inkorrekt inmatning!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("There is now such Weekday");
            }



            //Console.WriteLine("Skriv ett tal mellan 1 och 7");
            //int tal = int.Parse(Console.ReadLine());

            //string veckodag = Weekday(tal);
            //Console.WriteLine(veckodag);
        }
    }
}
