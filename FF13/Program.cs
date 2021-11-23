using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FF13
{
    class Program
    {

        static async Task<long> Summera(List<int> lista, int start, int end)
        {
            long summa = 0;
            await Task.Run(() =>
            {
                for (int i = start; i < end; i++)
                {
                    summa += lista[i];
                }
            });

            return summa;
        }

        static async void Main(string[] args)
        {
            // ----Vill ha ut summan av allt i "nummer"----
            // Skapar listan med 10000 siffror
            List<int> nummer = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                nummer.Add(i);
            }

            //// Skriva ut med loop
            //long summa = 0;
            //for (int i = 0; i < nummer.Count; i++)
            //{
            //    summa += nummer[i];
            //}
            //Console.WriteLine(summa);

            Stopwatch sw = new Stopwatch();
            //sw.Start();

            //// Skriva ut med vår metod Summera
            //long summa2 = Summera(nummer, 0, nummer.Count);
            //sw.Stop();
            //Console.WriteLine(summa2);
            //Console.WriteLine(sw.ElapsedMilliseconds);


            // Räkna ut delar av listan och skriva ut med Task---
            //sw.Reset();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            //sw.Start();
            //Task<long> första = new Task<long>(() => Summera(nummer, 0, 25000000));
            //Task<long> andra = new Task<long>(() => Summera(nummer, 25000000, 50000000));
            //Task<long> tredje = new Task<long>(() => Summera(nummer, 25000000, 50000000));
            //Task<long> fjärde = new Task<long>(() => Summera(nummer, 75000000, 100000000));

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

            //första.Wait();
            //andra.Wait();
            //tredje.Wait();
            //fjärde.Wait();

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


            //// ----Tasks med async/await----
            //int N = 0;
            //// lock för att synka så att nedan två tasks synkas. Utan lock ger nedan två tasks olika summa för N 
            //// varje gång beroende på hur snabba de är. De krockar helt enkelt.
            //object o = new object();

            //Task task = new Task(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        lock (o)
            //        {
            //            N++;
            //        } // Här plockas låset bort...

            //    }
            //});

            //Task task2 = new Task(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        lock (o)
            //        {
            //            N++;
            //        }
            //    }
            //});

            //task.Start();
            //task2.Start();

            //task.Wait();
            //task2.Wait();
            //Console.WriteLine(N);


            // -----ASYNC/AWAIT-----

            long första = await Summera(nummer, 0, 25000000);   // Samma som nedan. 
            var andra = await Summera(nummer, 25000000, 50000000);
            var tredje = await Summera(nummer, 25000000, 50000000);
            var fjärde = await Summera(nummer, 75000000, 100000000);

            long summa3 = första + andra + tredje + fjärde;
            Console.WriteLine(summa3);


        }
    }
}
