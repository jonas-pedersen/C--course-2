using System;
using System.Collections.Generic;
using System.Linq;

namespace FF10
{

    class MinKlass
    {
        // Dessa två varianter är likvärdiga:

        // 1.
        //private int tal;

        // 2.
        //public int Tal
        //{
        //    get
        //    {
        //        return tal;
        //    }
        //    private set
        //    {
        //        tal = value;
        //    }
        //}

        // Samma som ovan fast kortare sätt att skriva det på. 
        public int Tal { get; private set; }

    }

    // Istället för anonyma klasser kan vi skriva vår klass så här:
    class Company
    {
        public string CompanyName;
        public string City;
        public string Country;

        public Company(string cn, string c, string co)
        {
            CompanyName = cn;
            City = c;
            Country = co;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // -----LINQ - Language - Integrated Query-----

            // --Data som vi kommer att loopa igenom och leta efter saker. Simulerar databas.--
            var customers = new[]
            {
                new { CustomerID = 1, FirstName = "Kim", LastName = "Abercrombie", CompanyName = "Alpine Ski House" },
                new { CustomerID = 2, FirstName = "Jeff", LastName = "Hay", CompanyName = "Coho Winery" },
                new { CustomerID = 3, FirstName = "Charlie", LastName = "Herb", CompanyName = "Alpine Ski House" },
                new { CustomerID = 4, FirstName = "Chris", LastName = "Preston", CompanyName = "Trey Research" },
                new { CustomerID = 5, FirstName = "Dave", LastName = "Barnett", CompanyName = "Wingtip Toys" },
                new { CustomerID = 6, FirstName = "Ann", LastName = "Beebe", CompanyName = "Coho Winery" },
                new { CustomerID = 7, FirstName = "John", LastName = "Kane", CompanyName = "Wingtip Toys" },
                new { CustomerID = 8, FirstName = "David", LastName = "Simpson", CompanyName = "Trey Research" },
                new { CustomerID = 9, FirstName = "Greg", LastName = "Chapman", CompanyName = "Wingtip Toys" },
                new { CustomerID = 10, FirstName = "Tim", LastName = "Litton", CompanyName = "Wide World Importers" }
            };
            var addresses = new[]
            {
                new { CompanyName = "Alpine Ski House", City = "Berne", Country = "Switzerland"},
                new { CompanyName = "Coho Winery", City = "San Francisco", Country = "United States"},
                new { CompanyName = "Trey Research", City = "New York", Country = "United States"},
                new { CompanyName = "Wingtip Toys", City = "London", Country = "United Kingdom"},
                new { CompanyName = "Wide World Importers", City = "Tetbury", Country = "United Kingdom"}
            };



            // ---Ge mig en lista på förnamnet på alla kunder---
            List<string> förnamn = new List<string>();

            foreach (var customer in customers)
            {
                förnamn.Add(customer.FirstName);
            }

            // --Med LINQ--
            var förnamn2 = from customer in customers select customer.FirstName;
           
            var allaKunderFrånWingtim = from customer in customers 
                                        where customer.CompanyName == "Wingtip Toys"
                                        select customer;

            foreach (string  namn in förnamn2)
            {
                Console.WriteLine(namn);
            }



            // ---Ge mig namnet på alla företag i USA (filtrera)---
            Console.WriteLine("");
            List<string> amerikanska = new List<string>();

            foreach (var address in addresses)
            {
                if (address.Country == "United States")
                {
                    amerikanska.Add(address.CompanyName);
                }
            }

            foreach (string namn in amerikanska)
            {
                Console.WriteLine(namn);
            }


            // --Med LINQ--
            Console.WriteLine("\nMed LINQ");
            var amerikanska2 = from address in addresses
                               where address.Country == "United States" || address.City == "New York"
                               select address.CompanyName;

            foreach (string namn in amerikanska2)
            {
                Console.WriteLine(namn);
            }



            // ---Ge mig alla stadsnamn i bokstavsordning---
            Console.WriteLine("\n LINQ Städer i bokstavsordning");
            var städer = from address in addresses orderby address.City select address.City;

            foreach (string namn in städer)
            {
                Console.WriteLine(namn);
            }


            // ---Ge mig alla stadsnamn och respektive land, sorterade efter stadsnamn
            Console.WriteLine("\n LINQ Stadsnamn och respektive land i bokstavsordning");
            var städerOchLänder = from address in addresses
                                  orderby address.City
                                  select new { address.City, address.Country };

            foreach (var namn in städerOchLänder)
            {
                Console.WriteLine(namn);
            }



            // ---För en lista med alla kunders namn och landet de jobbar i
            Console.WriteLine("\nLista med alla kunders namn och landet de jobbar i");
            foreach (var customer in customers)
            {
                foreach (var address in addresses)
                {
                    if (customer.CompanyName == address.CompanyName)
                    {
                        Console.WriteLine($"{customer.FirstName} {customer.LastName}: {address.Country}");
                        break;
                    }
                }
            }


            // --Med LINQ--
            Console.WriteLine("\nLINQ Lista med alla kunder och de land de jobbar i");
            var nameAndCountry = from customer in customers
                                 join address in addresses
                                 on customer.CompanyName equals address.CompanyName
                                 select new { customer.FirstName, customer.LastName, address.Country };

            foreach (var result in nameAndCountry)
            {
                Console.WriteLine($"{result.FirstName} {result.LastName}: {result.Country}");
            }


        }
    }
}
