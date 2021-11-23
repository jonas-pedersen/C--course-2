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
                // ...
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
        public static void Sortera(int[] array)
        {
            // BubbleSort
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }

        private static (int, int) divide(int lhs, int rhs)
        {
            return (lhs / rhs, lhs % rhs);
        }

        static void Main(string[] args)
        {
            int div, rem;
            (div, rem) = divide(15, 4);
            Console.WriteLine($"15/3 = {div} rest {rem}");
        }
    }
}
