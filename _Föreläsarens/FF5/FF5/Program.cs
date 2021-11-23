using System;

namespace FF5
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p = new Punkt(3, 5);

            // ...
            // inkapsling
            p.X = 35;
            p.Y = 100;

            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);



            /*
            //Console.WriteLine(p.DistanceToCenter());

            //Console.WriteLine(Punkt.CenterDistance(p));
            
            Punkt q = new Punkt(10);

            Console.WriteLine(q.X);
            Console.WriteLine(q.Y);

            //Console.WriteLine(q.DistanceToCenter());

            Punkt r = (p + q) * 2;

            Console.WriteLine(r.X);
            Console.WriteLine(r.Y);



            Punkt[] points = new Punkt[] { new Punkt(1, 2), new Punkt(3, 4), new Punkt(5, 6) };

            Punkt[] copy_of_points = new Punkt[3];

            points.CopyTo(copy_of_points, 0);

            Array.Copy(points, copy_of_points, 3);


            Cirkel c = new Cirkel(3.5f);
            */

        }
    }
}
