using System;
using System.Collections.Generic;

namespace FF9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Generic) Collections
            // Data structures / Datastrukturer
            // List, Queue, HashSet, Dictionary

            //// -----LIST-----
            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(7);
            //numbers.Add(12);
            //numbers.Insert(0, 100);
            //numbers.Remove(7);
            //numbers.RemoveAt(1);  // 100, 12

            //numbers[1] = 200;    // 100, 200

            //// Byta plats på listplatser
            //(numbers[0], numbers[1]) = (numbers[1], numbers[0]);    // 200, 100

            //foreach (int tal in numbers)
            //{
            //    Console.WriteLine(tal);
            //}


            // -----Queue-----FIFO, First in first out.

            //// Fungerar lite annorluna än lista. Man kan inte trängas i kön. 
            //// Kan bara "push och pop". 
            //// Optimerad för att vi aldrig bryter ordningen och vill bara ha det som legat där längst (vi satte in först)
            //Queue<int> kö = new Queue<int>();
            //kö.Enqueue(3);
            //kö.Enqueue(5);
            //kö.Enqueue(12);

            //// Tar ej bort den som ligger först. Bara visar den.
            //Console.WriteLine("Peekar på nr: " + kö.Peek());

            //// Funkar, men funkar inte att skriva ut en specifik plats genom kö[1] tex.
            //foreach (int i in kö)
            //{
            //    Console.WriteLine(i);
            //}


            //// Vanligt förekommande loop
            //while (kö.Count > 0)
            //{
            //    Console.WriteLine($"Tar bort {kö.Dequeue()} från kön");
            //}


            // ---HashSet---
            // Snabb lookup och snabba jämförelser av grupper av data
            // Är mycket snabbare än Lista vid kolla upp data
            // Kan bara ha unika element
            // Tiden för att hitta saker här är konstant oavsett hur stor den är.
            // Är som en påse där man kastat ned sakerna i "listan". Finns ingen ordning.

            //HashSet<string> employees = new HashSet<string>();
            //employees.Add("Fred");
            //employees.Add("Bert");
            //employees.Add("Harry");
            //employees.Add("John");
            //// Funkar inte
            //Console.WriteLine(employees[0]);

            //HashSet<string> customers = new HashSet<string>();
            //customers.Add("John");
            //customers.Add("Sid");
            //customers.Add("Harry");
            //customers.Add("Diana");

            //foreach (string name in employees)
            //{
            //    Console.WriteLine(name);
            //}

            //employees.Add("Marcus");

            //// Kan bli olika utskrift mot ovan förutom Marcus
            //foreach (string name in employees)
            //{
            //    Console.WriteLine(name);
            //}

            //if (employees.Contains("Fred"))
            //{

            //}


            //// Metod för att se de som finns med i både customers och employees. Här "Harry" och "John"
            //// Modifierar här customers så att den bara innehåller de som är med i bägge.
            //customers.IntersectWith(employees);


            // ---Dictionary---
            // Används för att göra olika uppslag. Tex slå i en ordbok eller så...
            // Dictionary - Key-Value storage (Nyckel-Värde)
            Dictionary<string, int> ålder = new Dictionary<string, int>();
            ålder["Marcus"] = 100;
            ålder["Någon annan"] = 25;
            ålder["Person 3"] = 19;
            ålder.Add("George", 60);

            // Kan byta ut value genom att skriva 
            ålder["Marcus"] = 200;

            Console.WriteLine("Hur gammal är Marcus? Han är...");
            Console.WriteLine(ålder["Marcus"]);

            foreach (var element in ålder)
            {
                Console.WriteLine($"{element.Key} är {element.Value} år gammal");
            }



        }
    }
}
