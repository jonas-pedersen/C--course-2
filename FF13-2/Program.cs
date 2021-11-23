using System;
using System.Collections.Generic;
using System.Threading;

namespace FF13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAccelererbar> fordon = new List<IAccelererbar>();
            fordon.Add(new Cykel());
            fordon.Add(new Volvo());
            fordon.Add(new Rymdraket());

            float maxSträcka = 100;
            bool fortsätt = true;
            while (fortsätt)
            {
                Console.WriteLine("----");
                foreach (var f in fordon)
                {
                    f.Accelerera();

                    if (f.Distans > maxSträcka)
                    {
                        fortsätt = false;
                    }

                    Console.WriteLine(f);
                }
                Thread.Sleep(1000);

            }

        }
    }
}
