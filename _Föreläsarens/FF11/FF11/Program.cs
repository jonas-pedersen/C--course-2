using System;

namespace FF11
{
    class Program
    {
        delegate int MatteOperation(int a, int b);

        static int RäknaUt(MatteOperation metod, int första, int andra)
        {
            return metod(första, andra);
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int c, int d)
        {
            return c - d;
        }






        // ----



        delegate void EnVoidMetodUtanArgument();

        static bool KastarDennaMetodEnException(Action metod)
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

        static void Dålig()
        {
            throw new ArgumentException("Oops");
        }

        static void LiteBättre()
        {
            Console.WriteLine("hej");
        }

        static void KastarIbland(int i)
        {
            if (i == 0)
                throw new Exception("Oops");
        }

        //static void KastarIblandMed2() => KastarIbland(2);

        //static void KastarIblandMed0() => KastarIbland(0);

        static void SägHejdå() => Console.WriteLine("Hejdå!");

        static void Main(string[] args)
        {
            WeldingMachine welder = new WeldingMachine();
            PaintingMachine painter = new PaintingMachine();
            FoldingMachine folder = new FoldingMachine();




            Factory factory = new Factory();

            factory.StopMachines += welder.StopWelding;
            factory.StopMachines += painter.TurnOffPaint;
            factory.StopMachines += folder.StopFolding;
            //factory.StopMachines += SägHejdå;
            factory.StopMachines += () => Console.WriteLine("Hejdå!");

            // factory.StopMachines -= folder.StopFolding;

            factory.STOP();
            factory.StopMachines();






















            // --------------
            int summa = RäknaUt(Plus, 5, 4);

            int differens = RäknaUt(Minus, 9, 3);

            Console.WriteLine(summa);
            Console.WriteLine(differens);











            // LINQ
            //var customers = new[]
            //{
            //    new { Firstname = "Marcus", Lastname = "Näslund", CompanyName="TUC" }
            //};



            bool result = KastarDennaMetodEnException(Dålig);
            Console.WriteLine(result);

            result = KastarDennaMetodEnException(LiteBättre);
            Console.WriteLine(result);

            for (int i = 0; i < 100; i++)
            {
                result = KastarDennaMetodEnException(() => KastarIbland(i));
            }
            
            //result = KastarDennaMetodEnException(() => KastarIbland(0));


            // Assert.Throws<FormatException>(() => int.Parse("abc"));

            // Assert.Throws<FormatException>(int.Parse("abc"));

            // int x = int.Parse("abc");
            // Assert.Throws<FormatException>(x);
        }
    }
}
