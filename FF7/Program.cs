using System;

namespace FF7
{
    // Enumerations
    enum Season { Spring, Summer, Fall, Winter };

    // Skapar en enum att använda till miniräknaren. Visar även att man kan sätta värden på 
    // de olika sakerna i enum, tex att både Subtract och Minus ska tolkas som minus, eller att
    // Divide ska vara samma som siffran 2450 osv.
    enum Operation { Plus, Minus, Times, Divide = 2450, Add = Plus, Subtract = Minus };

    class Program
    {

        // Använder enum här för att vara tydligare med vad som händer i varje case.
        static int ComputeOp(int a, int b, Operation op)
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
                    throw new ArgumentException("Invalid operation");
            }
        }

        // Metod för att konvertera en sträng till enum med våra olika operationer.
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

                case "/":
                    return Operation.Divide;

                default:
                    throw new ArgumentException("Invalid operation");
            }
        }

        // Utan enum fast samma sak som ovan.
        static int Compute (int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }

        // Bra att använda detta till Snake sen!
        enum Direction { Up, Right, Down, Left };

        /// <summary>
        /// Flyttar en punkt i valfri riktning
        /// </summary>
        /// <param name="punkt"></param>
        /// <param name="direction">0 = Upp, 1 = Höger, 2 = Ner, 3 = Vänster</param>
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


        // MAIN---
        static void Main(string[] args)
        {
            //// ---Exempel med struct---
            //Time t = new Time(2, 20, 15);
            //Console.WriteLine(t.TotalSeconds());

            //// -Denna går då Time är en struct, dvs den fungerar som en värdetyp-
            //Time t2 = t;

            //t.Hours = 100;
            //Console.WriteLine(t.Hours);
            //Console.WriteLine(t2.Hours);
            //Console.WriteLine(t2.TotalSeconds());


            // --Exempel med enum--
            //int a = ComputeOp(3, 7, Operation.Plus);
            //int b = ComputeOp(3, 5, Operation.Minus);

            // -Betyder samma som nedan...då Operation.Plus är 0 osv.
            //int a = ComputeOp(3, 7, 0);
            //int b = ComputeOp(6, 9, 1);


            //Console.WriteLine("Skriv ett tal:");
            //int first = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv ett tal:");
            //int second = int.Parse(Console.ReadLine());
            //Console.WriteLine("Välj en operation: (+, -, *, /)");
            //string s = Console.ReadLine();

            // -Måste tyvärr konvertera den som användaren skrev in till en enum med nedan metod-
            //Operation op = ConvertToOp(s); 
            //int result = ComputeOp(first, second, op);


            // -Exempel där vi använder oss av vår enum igen- 
            // Newtons Andra lag-fallet
            //Console.WriteLine("Skriv in ett tal (massa):");
            //int massa = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv in accelarationen (a):");
            //int acc = int.Parse(Console.ReadLine());
            //int _result = ComputeOp(massa, acc, Operation.Times);


            Cirkel[] cirklar = new Cirkel[]{
                new Cirkel(1.0),
                new Cirkel(2.0),
                new Cirkel(5.5)
            };

            Rektangel[] rektanglar = new Rektangel[] { new Rektangel(7, 2), new Rektangel(5, 6) };


            // --Denna object array funkar på samma sätt som varianten med Figur nedan, bara att här 
            // --Tillåts vad som helst, dvs inte bra sätt att göra det på. 
            //object[] figurObj = new object[]
            //{
            //    new Cirkel(1.0),
            //    new Triangel(2.0, 88.0),
            //    new Cirkel(5.5),
            //    new Rektangel(3, 2.5),
            //    new Cirkel(2.0),
            //    new Rektangel(7, 10)
            //};

            // --Alternativ till det ovan. Denna lösning är bäst--
            // Fungerar om både Cirkel, Rektangel och Triangel ligger under klassen Figur
            Figur[] figurer = new Figur[]
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



            Rektangel r = new Rektangel(10, 20);
            r.Hello();



            // -----Lokala metoder-----Testar själv-----
            //int x = 5;   // -Används inte nedan då det x man anropar i metoderna är ifrån argumentet på metoden. 
            //int y = 10;

            //int lokalMetodMedFleraRader(int x)
            //{
            //    x += 3;
            //    return x * y;
            //}

            //int resultatAvGångerTvå = lokalMetodMedFleraRader(8);
            //Console.WriteLine(resultatAvGångerTvå);


            //int gångerTvåPil(int x) => x * 2;
            //Console.WriteLine(gångerTvåPil(6));


          

       

        }
    }
}
