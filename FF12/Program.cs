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
        // Definierar returtyp och argument-typ mha delegate
        public delegate bool NågotSomPassarFindAll(int tal);

        //static bool KastarDenHärEnException2(NågotSomPassarFindAll metod)
        //{
        //    try
        //    {
        //        metod();
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return true;
        //    }
        //}


        // Action används bara med void-metoder som inte tar några argument.
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

        static void KastarAlltid() => throw new ArgumentException("alla coola kids kastar exceptions");
    

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
            for (int i = start; i < end; i++)
            {
                summa += lista[i];
            }
            return summa;
        }

        static void Main(string[] args)
        {
            //bool result = KastarDenHärEnException(KastarAlltid);
            //Console.WriteLine(result);

            //// Eller som anonym funktion.
            //result = KastarDenHärEnException(() => throw new ArgumentException("alla coola kids kastar exceptions"));

            //result = KastarDenHärEnException(KastarAldrig);
            //Console.WriteLine(result);

            //List<int> nummer = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    nummer.Add(i);
            //}

            //// För att få ut nummer på plats 4
            //nummer[4]

            // ---Jag vill ha alla tal större än 75---

            //// Kan göra med LINQ
            //var större_än_75 = from tal in nummer where tal > 75 select tal;

            //// ---Eller med FindAll(...)---
            //// Kan göra så här, men det är vanligare med callback.
            //List<int> större_än_75b = nummer.FindAll(StörreÄn75);
            //foreach (var tal in större_än_75b)
            //{
            //    Console.WriteLine(tal);
            //}

            //// Vanligare så här (som i JavaScript)
            //List<int> större_än_75c = nummer.FindAll((tal) => tal > 75);
            //foreach (var tal in större_än_75c)
            //{
            //    Console.WriteLine(tal);
            //}
            //// Predicate (används i FindAll) är ett delegate som returnerar true eller false. Läs mer här......


            // ----Visa hur TASKS fungerar----
            //Console.WriteLine("Tjena!");
            // ---Smartare sätt än ovan---
            //Task task = new Task(SägHej);
            //task.Start();

            //// ...gör annat så länge...
            //Console.WriteLine("Ohoj!");
            //Console.WriteLine("Ohoj!");
            //Console.WriteLine("Ohoj!");
            //Console.WriteLine("Ohoj!");
            //Console.WriteLine("Ohoj!");

            //// Vänar in till task:en är färdig
            ////task.Wait();
            //Console.WriteLine("Hejdå!");


            // ----Vill ha ut summan av allt i "nummer"----
            // Skapar listan med 10000 siffror
            List<int> nummer = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                nummer.Add(i);
            }

            // Skriva ut med loop
            long summa = 0;
            for (int i = 0; i < nummer.Count; i++)
            {
                summa += nummer[i];
            }
            Console.WriteLine(summa);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //// Skriva ut med vår metod Summera
            //long summa2 = Summera(nummer, 0, nummer.Count);
            //sw.Stop();
            //Console.WriteLine(summa2);
            //Console.WriteLine(sw.ElapsedMilliseconds);


            // Räkna ut delar av listan och skriva ut med Task---
            sw.Reset();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Start();
            Task<long> första = new Task<long>(() => Summera(nummer, 0, 25000000));
            Task<long> andra = new Task<long>(() => Summera(nummer, 25000000, 50000000));
            Task<long> tredje = new Task<long>(() => Summera(nummer, 50000000, 75000000));
            Task<long> fjärde = new Task<long>(() => Summera(nummer, 75000000, 100000000));

            //// Med bara två tasks..
            ////Task<long> första2 = new Task<long>(() => Summera(nummer, 0, 50000000));
            ////Task<long> andra2 = new Task<long>(() => Summera(nummer, 50000000, 50000000));
            ////första2.Start();
            ////andra2.Start();
            ////long summa3 = första.Result + andra.Result;
            ////Console.WriteLine(summa3);

            //första.Start();
            //andra.Start();
            //tredje.Start();
            //fjärde.Start();

            ////första.Wait();
            ////andra.Wait();
            ////tredje.Wait();
            ////fjärde.Wait();

            //long summa3 = första.Result + andra.Result + tredje.Result + fjärde.Result;
            //sw.Stop();
            //Console.WriteLine(summa3);
            //Console.WriteLine(sw.ElapsedMilliseconds);


            // ----Tasks med lock----
            //int N = 0;
            //// lock för att synka så att nedan två tasks synkas. Utan lock ger nedan två tasks olika summa för N 
            //// varje gång beroende på hur snabba de är. De krockar helt enkelt.
            //object o = new object();

            //Task task = new Task(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        lock(o)
            //        {
            //            N++;
            //        }  // Här plockas låset bort...

            //    }  
            //});

            //Task task2 = new Task(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        lock (o)
            //        {
            //            N++;
            //        }  // Här plockas låset bort...
            //    } 
            //});

            //task.Start();
            //task2.Start();

            //task.Wait();
            //task2.Wait();
            //Console.WriteLine(N);


            // ----Tasks med async/await----
            int N = 0;
            // lock för att synka så att nedan två tasks synkas. Utan lock ger nedan två tasks olika summa för N 
            // varje gång beroende på hur snabba de är. De krockar helt enkelt.
            object o = new object();

            Task task = new Task(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    lock (o)
                    {
                        N++;
                    } // Här plockas låset bort...

                }
            });

            Task task2 = new Task(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    lock (o)
                    {
                        N++;
                    }
                }
            });

            task.Start();
            task2.Start();

            task.Wait();
            task2.Wait();
            Console.WriteLine(N);


   


        }
    }
}
