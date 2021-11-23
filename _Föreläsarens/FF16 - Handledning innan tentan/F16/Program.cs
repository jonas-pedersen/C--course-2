using System;
using System.Collections.Generic;
using System.Linq;

namespace F16
{
    public interface IAccelerable
    {
        public void Gasa();
        public void Bromsa();
    }

    public class Cykel: IAccelerable
    {
        public float Hastighet = 0;

        /// <summary>
        /// Ökar hastigheten så snabbt som en cykel kan, dvs 0.5f
        /// </summary>
        public void Gasa()
        {
            Hastighet += 0.5f;
        }

        public void Bromsa()
        {
            Hastighet -= 0.5f;
            if (Hastighet < 0)
            {
                Hastighet = 0;
            }
        }
    }

    public abstract class Bil: IAccelerable
    {
        public float Acceleration { get; set; }
        public float Hastighet { get; set; }

        public Bil(float acceleration)
        {
            Acceleration = acceleration;
            Hastighet = 0;
        }

        /// <summary>
        /// Ökar hastigheten enligt den givna accelerationen
        /// </summary>
        public void Gasa()
        {
            Hastighet += Acceleration;
        }

        public void Bromsa()
        {
            Hastighet -= Acceleration;
            if (Hastighet < 0)
            {
                Hastighet = 0;
            }
        }
    }

    public class Volvo : Bil
    {      

        public Volvo() : base(3.5f)
        {
        }
    }

    public class Mercedes : Bil
    {
        public Mercedes() : base(4.5f)
        {
        }
    }

    class VolvoGarage
    {
        public List<Volvo> bilar;
        //...
    }

    class MercedesGarage
    {
        public List<Mercedes> bilar;
        //...
    }

    class Garage<T> where T : Bil
    {
        public List<T> bilar;
        // ...
    }

    public class AnnatMärke : Bil
    {
        public AnnatMärke(float acceleration) : base(acceleration)
        {
        }
    }

    class TidÄrNegativException : Exception
    {

    }

    class Duett<T1, T2>
    {
        private T1 ena;
        private T2 andra;

        public Duett(T1 a, T2 b)
        {
            ena = a;
            andra = b;
        }

        public T1 FåEna()
        {
            return ena;
        }

        public T2 FåAndra()
        {
            return andra;
        }
    }

    class Program
    {
        static int TidKvar(int timmar, int minuter, int sekunder)
        {
            if (timmar < 0 || minuter < 0 || sekunder < 0)
            {
                throw new TidÄrNegativException();
            }
            return sekunder + 60 * minuter + 60 * 60 * timmar;
        }

        static void Main(string[] args)
        {
            // Assert.AreEqual(65, Program.TidKvar(0, 1, 5));
            // Assert.AreEqual(3600, Program.TidKvar(1, 0, 0));
            // Assert.AreEqual(0, Program.TidKvar(1, -2, 3));
            // Assert.AreEqual(0, Program.TidKvar(-1, 2, 3));
            // Assert.AreEqual(0, Program.TidKvar(1, 2, -3));

            // Assert.Throws<TidÄrNegativException>(() => Program.TidKvar(1, -2, 3));

            List<IAccelerable> accelererbaraObjekt = new List<IAccelerable>();
            Volvo volvo = new Volvo();
            accelererbaraObjekt.Add(volvo);

            Cykel cykel = new Cykel();
            accelererbaraObjekt.Add(cykel);

            foreach (var fordon in accelererbaraObjekt)
            {
                fordon.Gasa();
            }

            Garage<Volvo> volvobilar = new Garage<Volvo>();
            volvobilar.bilar.Add(new Volvo());

            Garage<Mercedes> mercedesbilar = new Garage<Mercedes>();
            mercedesbilar.bilar.Add(new Mercedes());

            // Garage<int> intbilar = new Garage<int>();

            Duett<int, bool> par = new Duett<int, bool>(5, true);

            // ...

            int femma = par.FåEna();
            bool sant = par.FåAndra();

            Console.WriteLine(femma);
            Console.WriteLine(sant);

            List<int> listan = new List<int>();
            for (int i=1; i<=100; i++)
            {
                listan.Add(i);
            }

            var result = from tal in listan where tal > 50 select tal;

            var omvänd = from tal in listan orderby tal descending select tal;

            var favoriter = new[] {
                new { Namn = "Marcus", Favorittal = 42 },
                new { Namn = "Omöjlig", Favorittal = 123456},
                new { Namn = "Tedrickaren", Favorittal = 10}
            };

            var personer_med_bra_favorittal = from person in favoriter where listan.Contains(person.Favorittal) select person.Namn;
            var personer_med_dåliga_favorittal = from person in favoriter where !listan.Contains(person.Favorittal) select person.Namn;

            var personer_med_bra_favorittal_2 = from person in favoriter where person.Favorittal >= 1 && person.Favorittal <= 100 select person.Namn;
            var personer_med_dåliga_favorittal_2 = from person in favoriter where person.Favorittal < 1 || person.Favorittal > 100 select person.Namn;


            var result2 = listan.FindAll(StörreÄnFemtio);
            //var result = listan.FindAll((tal) => tal > 50);

            foreach (int tal in result2)
            {
                Console.WriteLine(tal);
            }

            listan.RemoveAll((tal) => tal >= 10 && tal <= 20);
            foreach (int tal in listan)
            {
                Console.WriteLine(tal);
            }
        }

        public static bool StörreÄnFemtio(int tal) => tal > 50;
    }
}
