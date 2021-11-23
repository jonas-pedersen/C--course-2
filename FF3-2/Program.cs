using System;

namespace FF3_2
{
    public class Program
    {
        public static string Weekday(int n)
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
                    throw new ArgumentException("Ajabaja!");
            }
        }

        // Skriv en metod som tar en int-array som input
        // och ordnar om elementen i stigande ordning (sorterar)
        // Exempel: In kommer [2, 5, 4, 1, 3]
        //                    [2, 4, 1, 3, 5]
        //                    [2, 1, 3, 4, 5]
        // Efteråt är arrayen [1, 2, 3, 4, 5]
        public static void Sortera(int[] enArray)
        {
            // Kan sortera med Array.Sort
            //Array.Sort(enArray);


            // ...eller med BubbleSort
            for (int j = 0; j < enArray.Length; j++)
            {
                // Denna loopas inte hela längden då man hela tiden jämför med i + 1.
                for (int i = 0; i < enArray.Length - 1; i++)
                {
                    if (enArray[i] > enArray[i + 1])
                    {
                        int temp = enArray[i];
                        enArray[i] = enArray[i + 1];
                        enArray[i + 1] = temp;
                    }
                }
            }

            // Skriver ut för att se att sorteringen blev rätt. 
            foreach (var el in enArray)
            {
                Console.WriteLine(el);
            }
        }

        // Returnera flera typer
        private static (int, int) divide(int lhs, int rhs)
        {
            return (lhs / rhs, lhs % rhs);
        }

        private static (string, string) SwitchNames(string name1, string name2)
        {
            return (name2, name1);
        }

        static void Main(string[] args)
        {
            // Sortera
            int[] testArr = new int[] { 2, 5, 4, 1, 3 };
            Sortera(testArr);


            // Returnera två variabler - Exempel 1
            int div, rem;
            (div, rem) = divide(15, 4);
            Console.WriteLine($"15/3 = {div} rest {rem}");


            // Returnera två variabler - Exempel 2
            string kille = "Jonas";
            string tjej = "Ellen";



            (kille, tjej) = SwitchNames(kille, tjej);

            Console.WriteLine($"Killen är nu {kille}, tjejen är nu {tjej}");
        }
    }
}
