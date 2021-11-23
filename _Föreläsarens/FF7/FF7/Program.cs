using System;

namespace FF7
{
    // Enumerations
    enum Season { Spring, Summer, Fall, Winter };

    enum Operation { Plus, Minus, Times = 100, Divide };

    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="op">0 betyder plus, 1 minus, 2 gånger, osv</param>
        /// <returns></returns>
        //static int Compute(int a, int b, Operation op)
        static int Compute(int a, int b, Operation op)  // :)
        {
            switch (op)
            {
                case Operation.Plus:
                    return a + b;
                case Operation.Minus:
                    return a - b;
                case Operation.Times:
                    return a * b;
                case Operation.Divide:
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation!");
            }
        }

        static Operation ConvertToOp(string s)
        {
            switch (s)
            {
                case "+":
                    return Operation.Plus;
                case "-":
                    return Operation.Minus;
                case "*":
                    return Operation.Times;
                default:
                    throw new ArgumentException("Invalid operator");
            }

        }

        enum Direction { Up, Right, Down, Left };

        /// <summary>
        /// Flyttar en punkt ett steg i valfri riktning
        /// </summary>
        /// <param name="punkt"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        static Punkt Move(Punkt punkt, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return new Punkt(punkt.X, punkt.Y - 1);
                case Direction.Right:
                    return new Punkt(punkt.X + 1, punkt.Y);
                case Direction.Down:
                    return new Punkt(punkt.X, punkt.Y + 1);
                case Direction.Left:
                    return new Punkt(punkt.X - 1, punkt.Y);
                default:
                    return punkt;
            }
                
        }

        static void Main(string[] args)
        {
            Figur[] figurer = new Figur[]  // alternativet är att ha en object[] array, men då tillåter vi *vad som helst*
            {
                new Cirkel(1.0),
                new Triangel(2.0, 88.0),
                new Cirkel(5.5),
                new Rektangel(3, 2.5),
                new Cirkel(2.0),
                new Rektangel(7, 10)
            };

            foreach (var figur in figurer)
            {
                Console.WriteLine(figur);
                Console.WriteLine(figur.Area());
                figur.Hello();
            }


            /*
            Console.WriteLine("Skriv ett tal:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj en operation: (+, -, *, /)");
            string s = Console.ReadLine();
            Operation op = ConvertToOp(s);  // :/
            int result = Compute(first, second, op);

            // NEWTONS ANDRA LAG-fallet
            Console.WriteLine("Skriv ett tal (massa):");
            int _first = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal (acc):");
            int _second = int.Parse(Console.ReadLine());
            int _result = Compute(_first, _second, Operation.Times);


            int a = Compute(3, 7, Operation.Plus);
            int b = Compute(3, 5, Operation.Minus);

            Time t = new Time(2, 20, 15);
            Console.WriteLine(t.TotalSeconds());

            Time t2 = t;
            t.Hours = 1000000;
            Console.WriteLine(t2.TotalSeconds());
            */
        }
    }
}
