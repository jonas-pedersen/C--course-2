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

        static void Main(string[] args)
        {
            // async await
            List<int> nummer = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                nummer.Add(i);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();
            long summa = 0;
            foreach (int tal in nummer)
            {
                summa += tal;
            }
            sw.Stop();
            Console.WriteLine(summa);
            Console.WriteLine(sw.ElapsedMilliseconds);

            // Räkna ut delar av listan!
            sw.Reset();
            sw.Start();
            //Task<long> första = new Task<long>(() => Summera(nummer, 0, 25000000));
            //Task<long> andra = new Task<long>(() => Summera(nummer, 25000000, 5000000));
            //Task<long> tredje = new Task<long>(() => Summera(nummer, 50000000, 75000000));
            //Task<long> fjärde = new Task<long>(() => Summera(nummer, 75000000, 100000000));

            //första.Start();
            //andra.Start();
            //tredje.Start();
            //fjärde.Start();

            //första.Wait();
            //andra.Wait();
            //tredje.Wait();
            //fjärde.Wait();

            var första = Summera(nummer, 0,        25000000);
            var andra  = Summera(nummer, 25000000, 50000000);
            var tredje = Summera(nummer, 50000000, 75000000);
            var fjärde = Summera(nummer, 75000000, 100000000);
            //Thread.Sleep(200);
            long summa2 = första.Result + andra.Result + tredje.Result + fjärde.Result;
            sw.Stop();
            Console.WriteLine(summa2);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
