using System;

namespace FF11
{
    class Program
    {
        
      

        // Med signatur så menar man vad det är för typer.
        // Med Action är det bara metoder som är av void och inte tar några argument.
        // Delegate blir som en sorts mall för hur metoden ska vara. Beskriver typ en metod på samma sätt som ett
        // interface beskriver en klass.

        // Deletate MatteOperation. Kan vara vart som helst, behöver inte vara i en egen klass. 
        delegate int MatteOperation(int a, int b);
        
        static int RäknaUt(MatteOperation metod, int första, int andra)
        {
            return metod(första, andra);
        }
        static int Plus(int a, int b) => a + b;
        static int Minus(int a, int b) => a - b;




        // Samma sak som Action, då det är en void-metod utan argument. 
        delegate void EnVoidMetodUtanArgument();

        static bool KastarDennaMetodEnException(EnVoidMetodUtanArgument metod)
        {
            try
            {
                metod();
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        // static bool KastarDennaMetodEnException(Action<int, float, bool> metod)

        // Samma metod som ovan fast med Action istället för delegate:t
        static bool KastarDennaMetodEnException2(Action metod)
        {
            try
            {
                metod();
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        // Metod som kastar Exception
        static void Dålig()
        {
            throw new ArgumentException("Oops");
        }

        // Metod som inte kastar Exception
        static void LiteBättre()
        {
            Console.WriteLine("Hej!");
        }

        // Metod som kastar Exception när i är 0.
        static void KastarIbland(int i)
        {
            if (i == 0)
            {
                throw new Exception("Ojdå!");
            }
        }

        // Hjälpmetoder för att kunna testa KastarIbland()
        static void KastarIblandMed2() => KastarIbland(2);
        static void KastarIblandMed0() => KastarIbland(0);


        static void SägHejdå() => Console.WriteLine("Hejdå!");

        // -----Lär mig lite om delegate själv-----
        delegate void PrintDelegate1(string s);
        delegate void PrintDelegate2();
        static void PrintMetod() => Console.WriteLine("Vanlig void-metod och det skrivs ut");


        static void Main(string[] args)
        {
            // -----Lär mig lite om delegate själv-----
            PrintDelegate1 print1 = (mess) =>
            {
                mess += " på dig";
                Console.WriteLine(mess);
            };
           


            PrintDelegate2 print2 = () => { 
                
                Console.WriteLine("Skrivs också ut!!");
                Console.WriteLine("Fortfarande inne i print2!!");
            };
            print1("Hej!");
            print2();
            PrintMetod();

            

            // I C# så skriver man en enkel "Action" eller metod som kan jämföras med JS const metod = () => gör ngt
            Action printAction = () => Console.WriteLine("Lite Action tack!!!");
            printAction();

            //// Jämför ovan "Action" med JavaScript
            //const printMetod = () => console.log("Nu skrivs det banne mig ut!!!")
            //printMetod();



            //Assert.Throws<FormatException>(() => int.Parse("abc"));

            // Kastar Exception direkt. 
            //Assert.Throws<FormatException>(int.Parse("abc"));
            // int x = int.Parse("abc");
            // Assert.Throws<FormatException>(x);



            // Referens till en metod. Därför har vi inte paranteser på Dålig() eller LiteBättre()
            bool result = KastarDennaMetodEnException(Dålig);
            Console.WriteLine(result);

            result = KastarDennaMetodEnException(LiteBättre);
            // Samma som ovan fast att metoden ser lite annorlunda ut. 
            result = KastarDennaMetodEnException2(LiteBättre);
            Console.WriteLine(result);

            // För att kunna ha en metod som har inparameter, som inparameter till KastarDennaMetodEnException 
            // Dvs, här med hjälp-metod. 
            result = KastarDennaMetodEnException(KastarIblandMed2);

           
            // Ovan kan skivas som...dvs utan hjälpmetoderna ovan. 
            result = KastarDennaMetodEnException(() => KastarIbland(2));
            result = KastarDennaMetodEnException(() => KastarIbland(0));

            for (int i = 0; i < 100; i++)
            {
                result = KastarDennaMetodEnException(() => KastarIbland(i));
            }


            // -----LINQ-----
            // --Anonyma klasser--
            var customers = new[]
            {
                new { FirstName = "Marcus", LastName = "Näslund", CompanyName = "TUC"}
            };

            // --Anonyma metoder--
            int summa = RäknaUt(Plus, 4, 6);

            int differens = RäknaUt(Minus, 10, 5);

            int summa2 = RäknaUt((x, y) => x + y, 4, 6);

            // -Typ som en arrow function ifrån JS
            Func<int, int, string> PlusLambdaVariantGammal = (a, b) => $"Lambda är {a + b}";


            Func<int, int, string> PlusLambdaVariant = (a, b) => 
                {
                    Console.WriteLine("Plus körs!");
                    return $"Lambda är {a + b}";
                
                };

            Console.WriteLine(PlusLambdaVariant(6, 8));
            // -Går t.o.m att ge funktionen ett nytt värde/ny funktion
            PlusLambdaVariant += (a, b) =>
            {
                return $"Lambda är {a - b}";
            };
            Console.WriteLine(PlusLambdaVariant(6, 8));
            
            Console.WriteLine($"Detta är summa {summa}");
            Console.WriteLine($"Detta är summa2 {differens}");
            Console.WriteLine($"Detta är summa2 {summa2}");
            

            WeldingMachine welder = new WeldingMachine();
            PaintingMachine painter = new PaintingMachine();
            FoldingMachine folder = new FoldingMachine();

            Factory factory = new Factory();

            factory.StopMachines += welder.StopWelding;
            factory.StopMachines += painter.TurnOffPaint;
            factory.StopMachines += folder.StopFolding;
            factory.StopMachines += () => Console.WriteLine("Hejdå!");
            // Samma sak som ovan
            //factory.StopMachines += SägHejdå;

            


            // Kan hantera private och även hantera null. Denna ska användas.
            factory.STOP();
            // Ger samma resultat men hanterar inte null-checken som vi gör i STOP-metoden. Denna bör ej användas. 
            //factory.StopMachines();
           

        }

    }
}
