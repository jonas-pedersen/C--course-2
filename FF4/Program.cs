using System;

namespace FF4
{
    class Program
    {
        #region De Bra regionerna
        /// <summary>
        /// Computes the value of a and b given an operator (+, -, *, /)
        /// </summary>
        /// <param name="a"> The first value </param>
        /// <param name="b"> The second value </param>
        /// <param name="op"> A mathematical operator (+, -, *, /) as string </param>
        /// <returns> The result of the operation </returns>
        static int Compute(int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;

                default:
                    throw new ArgumentException();
            }
        }

        #endregion

      
        static void Hej()
        {
/*            asfdadfs
                asdg
                asdg
                adg*/
        }

        static void Main(string[] args)
        {
            Compute(3, 5, "+");
            
            Console.WriteLine("Hello World!");
        }
    }
}
