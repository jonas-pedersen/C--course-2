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

            // List - Flexiblare array
            List<int> numbers = new List<int>();
            numbers.Add(3);   // 3
            numbers.Add(7);   // 3, 7
            numbers.Add(12);  // 3, 7, 12
            numbers.Insert(0, 100);  // 100, 3, 7, 12
            numbers.Remove(7);  // 100, 3, 12
            numbers.RemoveAt(1);  // 100, 12
            foreach (int tal in numbers)
            {
                Console.WriteLine(tal);
            }

            // Queue - FIFO first in, first out
            // Optimerad för att vi aldrig bryter ordningen och bara vill ha det som är "äldst"
            Queue<int> kö = new Queue<int>();
            kö.Enqueue(3);
            kö.Enqueue(5);
            kö.Enqueue(12);

            while (kö.Count > 0)
            {
                Console.WriteLine(kö.Dequeue());
            }

            // HashSet
            // Snabb lookup och snabba jämförelser av grupper av data.
            // Kan bara ha unika element
            HashSet<string> employees = new HashSet<string>();
            employees.Add("Fred");
            employees.Add("Bert");
            employees.Add("Harry");
            employees.Add("John");

            HashSet<string> customers = new HashSet<string>();
            customers.Add("John");
            customers.Add("Sid");
            customers.Add("Harry");
            customers.Add("Diana");

            foreach (string name in employees)
            {
                Console.WriteLine(name);
            }

            if (employees.Contains("Fred"))
            {

            }

            customers.IntersectWith(employees);

            // Dictionary - Key-Value storage (Nyckel-Värde)
            // Fungerar som en ordbok eller liknande
            // Nycklar är alltid unika!
            Dictionary<string, string> efternamn = new Dictionary<string, string>();
            efternamn["Marcus"] = "Näslund";
            efternamn["Marcus"] = "ABC";

            Dictionary<string, int> ålder = new Dictionary<string, int>();
            ålder["Marcus"] = 100;
            ålder["Någon annan"] = 25;
            ålder["Person 3"] = 19;
            ålder.Add("George", 60);

            Console.WriteLine("Hur gammal är Marcus? Han är...");
            Console.WriteLine(ålder["Marcus"]);

            foreach (var element in ålder)
            {
                Console.WriteLine($"{element.Key} är {element.Value} år gammal!");
            }
        }
    }
}
