using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FF12
{
    class Program
    {
        public delegate bool NågotSomPassarFindAll(int tal);

        static bool KastarDenHärEnException(Action metod)
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

        // static void KastarAlltid() => throw new ArgumentException("alla coola kids kastar exceptions");

        static void KastarAldrig()
        {
            int x = 3;
        }

        static bool StörreÄn75(int tal) => tal > 75;

        static void SägHej()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hejsan");
        }

        static long Summera(List<int> lista, int start, int end)
        {
            long summa = 0;
            for (int i=start; i<end; i++)
            {
                summa += lista[i];
            }
            return summa;
        }

       
        static void Main(string[] args)
        {
            int N = 0;
            object o = new object();

            Task task = new Task(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    lock (o)
                    {
                        N = N + 1;
                    }
                }
            });
            Task task2 = new Task(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    lock (o)
                    {
                        N = N + 1;
                    }
                }
            });

            task.Start();
            task2.Start();
            task.Wait();
            task2.Wait();
            Console.WriteLine(N);

            // ---
            List<int> nummer = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                nummer.Add(i);
            }

            Stopwatch sw = new Stopwatch();

            // Vill ha ut summan av allt i "nummer"
            sw.Start();
            long summa = Summera(nummer, 0, nummer.Count);
            sw.Stop();
            Console.WriteLine(summa);
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Räkna ut delar av listan!
            sw.Reset();
            sw.Start();
            Task<long> första = new Task<long>(() => Summera(nummer, 0, 50000000));
            Task<long> andra = new Task<long>(() => Summera(nummer, 50000000, 100000000));
            //Task<long> tredje = new Task<long>(() => Summera(nummer, 50000000, 75000000));
            //Task<long> fjärde = new Task<long>(() => Summera(nummer, 75000000, 100000000));

            första.Start();
            andra.Start();
            //tredje.Start();
            //fjärde.Start();

            // ...

            //första.Wait();
            //andra.Wait();
            //tredje.Wait();
            //fjärde.Wait();

            long summa2 = första.Result + andra.Result; // + tredje.Result + fjärde.Result;
            sw.Stop();
            Console.WriteLine(summa2);
            Console.WriteLine(sw.ElapsedMilliseconds);

            List<int> nummer = new List<int>();
            for (int i=0; i<100; i++)
            {
                nummer.Add(i);
            }

            // Jag vill ha alla tal större än 75
            // Kan göra med en vanlig for-loop

            // Kan göra med LINQ
            var större_än_75 = from tal in nummer where tal > 75 select tal;

            // Kan göra det med FindAll(...)
            //List<int> större_än_75b = nummer.FindAll(StörreÄn75);
            List<int> större_än_75b = nummer.FindAll((tal) => tal > 75);


            foreach (int tal in större_än_75b)
            {
                Console.WriteLine(tal);
            }


            bool result = KastarDenHärEnException(() => throw new ArgumentException("alla coola kids kastar exceptions"));
            Console.WriteLine(result);

            result = KastarDenHärEnException(KastarAldrig);
            Console.WriteLine(result);
        }
    }
}
