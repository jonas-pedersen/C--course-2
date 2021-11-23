using System;
using System.Collections.Generic;
using System.Linq;

namespace F10
{
    // Istället för anonyma klasser skulle vi kunna göra våra egna klasser såhär och använda om vi vill
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
            // Funkar lika bra med arrayer som med listor och andra datastrukturer
            // just nu använder vi arrayer.
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


            // Ge mig en lista med varje person och det land som personen jobbar i (där vi vet)
            var personAndCountry = from a in addresses
                                   join c in customers on a.CompanyName equals c.CompanyName
                                   select new { c.FirstName, c.LastName, a.Country };

            foreach (var x in personAndCountry)
            {
                Console.WriteLine(x);
            }


            // Ge mig alla företagsnamn i alfabetisk ordning
            var sortedCompanyNames = from company in addresses
                                     orderby company.CompanyName
                                     select company.CompanyName;

            //foreach (string s in sortedCompanyNames)
            //{
            //    Console.WriteLine(s);
            //}



            // Ge mig namnet på alla företag i USA
            /*
            List<string> usCompanies = new List<string>();
            foreach (var company in addresses)
            {
                if (company.Country == "United States")
                {
                    usCompanies.Add(company.CompanyName);
                }
            }
            */
            var usCompanies = from company in addresses 
                              where company.Country == "United States"
                              select company.CompanyName;



            // Ge mig alla förnamn bland alla kunder (customers)

            /*
            List<string> firstnames = new List<string>();
            foreach (var cust in customers)
            {
                firstnames.Add(cust.FirstName);
            }
            */

            // var firstnames = customers.Select(kund => kund.FirstName);

            // LINQ - Language-Integrated Query
            var firstnames = from cust in customers select cust.FirstName;


            //foreach (string name in firstnames)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
