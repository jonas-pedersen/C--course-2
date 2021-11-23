using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class LagerInfo
    {
        public int Pris;
        public string Hylla;
        public int Lagersaldo;
    }

    [TestClass]
    public class Uppgift3
    {
        [TestMethod]
        public void Uppg()
        {
            // (6p)

            // Utifrån arrayerna nedan, hämta ut följande information med
            // (a) vanlig kod, loopar och if-satser och dylikt
            // (b) ett LINQ-uttryck

            var varor = new[]
            {
                new { Namn = "Äpplen", Hylla = "B23", Lagersaldo = 150 },
                new { Namn = "Juice", Hylla = "D3", Lagersaldo = 50 },
                new { Namn = "Havregryn", Hylla = "A20", Lagersaldo = 5 },
                new { Namn = "Choklad", Hylla = "F4", Lagersaldo = 4 },
                new { Namn = "Päron", Hylla = "B23", Lagersaldo = 8 },
                new { Namn = "Vetemjöl", Hylla = "A20", Lagersaldo = 100 }
            };

            var priser = new[]
            {
                new { Namn = "Äpplen", Pris = 12 },
                new { Namn = "Juice", Pris = 32 },
                new { Namn = "Havregryn", Pris = 22 },
                new { Namn = "Choklad", Pris = 10 },
                new { Namn = "Päron", Pris = 13 },
                new { Namn = "Vetemjöl", Pris = 50 }
            };


            // (1) Alla varunamn
            List<string> varunamn = new List<string>();
            foreach (var vara in varor)
            {
                varunamn.Add(vara.Namn);
            }

            var varunamn2 = from vara in varor select vara.Namn;

            // (2) Alla hyllplan, sorterade efter lagersaldo
            string[] hyllor = new string[varor.Length];
            int[] lagersaldon = new int[varor.Length];
            for (int i=0; i<varor.Length; i++)
            {
                hyllor[i] = varor[i].Hylla;
                lagersaldon[i] = varor[i].Lagersaldo;
            }
            Array.Sort(lagersaldon, hyllor);

            var hyllor2 = from vara in varor orderby vara.Lagersaldo select vara.Hylla;




            // (3) Alla hyllor där lagersaldot < 10
            List<string> småhyllor = new List<string>();
            foreach (var vara in varor)
            {
                if (vara.Lagersaldo < 10)
                {
                    småhyllor.Add(vara.Hylla);
                }
            }
            var småhyllor2 = from vara in varor where vara.Lagersaldo < 10 select vara;


            // (4) En ny lista med bara Pris, Hylla och Lagersaldo (inte Namn) för varje artikel
            List<LagerInfo> result = new List<LagerInfo>();
            foreach (var vara in varor)
            {
                foreach (var pris in priser)
                {
                    if (vara.Namn == pris.Namn)
                    {
                        result.Add(new LagerInfo { 
                            Hylla = vara.Hylla, Lagersaldo = vara.Lagersaldo, Pris = pris.Pris 
                        });
                    }
                }
            }

            var result2 = from vara in varor
                          join pris in priser
                          on vara.Namn equals pris.Namn
                          select new LagerInfo{ Hylla = vara.Hylla, Lagersaldo = vara.Lagersaldo, Pris = pris.Pris };
        }
    }
}
