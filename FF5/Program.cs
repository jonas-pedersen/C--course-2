using System;

namespace FF5
{
    class Program
    {
        static void Main(string[] args)
        {

            Punkt p = new Punkt(3, 5);

            Console.WriteLine(p.X);
            //Console.WriteLine(p.Y);
            p.X = 23;
            //p.Y = 56;

            //Console.WriteLine(p.X);
            //Console.WriteLine(p.Y);

            // Icke statisk metod, Refererar till ett visst objekt. Här p
            Console.WriteLine(p.DistanceToCenter());

            // Statisk metod kan skicka in vilken Punkt som helst i CenterDistance()
            Console.WriteLine(Punkt.CenterDistance(p));

            Punkt q = new Punkt(10);

            Console.WriteLine(q.X);
            Console.WriteLine(q.Y);

            Console.WriteLine(q.DistanceToCenter());


            Punkt r = p + q;
            Punkt r2 = p * 2;
            Console.WriteLine(r.X);
            Console.WriteLine(r.Y);
            Console.WriteLine(r2.Y);



            Punkt[] points = new Punkt[] { new Punkt(1, 2), new Punkt(3, 4), new Punkt(5, 6) };

            Punkt[] copyOfPoints = new Punkt[3];

            // Gör exakt samma sak men den nedre är statisk metod. 
            points.CopyTo(copyOfPoints, 0);
            Array.Copy(points, copyOfPoints, 3);

            Cirkel c = new Cirkel(3.5f);

        }
    }
    
}


