using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    class Person
    {
        public string Namn;
        public Person(string n)
        {
            Namn = n;
        }
    }

    class Rackethall
    {
        public int BadmintonOchTennisBanor { get; private set; }
        public int MaxPersoner { get; private set; }

        private List<Person> spelare = new List<Person>();
        private Dictionary<Person, int> tilldelning = new Dictionary<Person, int>();

        public Rackethall(int banor, int maxpersoner)
        {
            BadmintonOchTennisBanor = banor;
            MaxPersoner = maxpersoner;
        }

        public void Spela(Person person, int bana)
        {
            spelare.Add(person);
            tilldelning.Add(person, bana);
        }

        public int LedigaPlatser()
        {
            return MaxPersoner - spelare.Count;
        }

        public bool KontrolleraBanor()
        {
            foreach (var spelareOchBana in tilldelning)
            {
                if (spelareOchBana.Value < 1 || spelareOchBana.Value > BadmintonOchTennisBanor)
                {
                    return false;
                }
            }
            return true;
        }
    }

    [TestClass]
    public class Uppgift6
    {
        [TestMethod]
        public void Uppg()
        {
            // (12p)

            // Vi är ansvariga för att skapa ett bokningssystem för en Rackethall som erbjuder både Tennis och Badminton.
            // Banorna är numrerade 1, 2, 3, ...
            // En viss person kan naturligtvis bara spela på en bana. Vi har också restriktioner kring hur många personer som får befinna sig i hallen samtidigt.

            // Skriv en klass Rackethall (rad 17) som har:
            // * En int-property BadmintonOchTennisBanor som inte kan ändras utifrån
            // * En int-property MaxPersoner som inte kan ändras utifrån
            // * En konstruktor med två argument som sätter värdena ovanför
            // * En privat lista med typen Person (se klassen ovan)
            // * En privat dictionary där nyckeln (key) är en Person och värdet är en int (en viss bana)
            // * En metod Spela(Person, int) som lägger till en person i ovanstående List och till ovanstående Dictionary
            // * En metod LedigaPlatser() som returnerar hur många fler personer som får vistas i hallen (jämför med MaxPersoner)
            // * En metod KontrolleraBanor() som går igenom din dictionary och verifierar att alla personer spelar på en giltig bana (mellan 1 och BadmintonOchTennisBanor).

            // Kommentera ut följande tester för att kontrollera om du gjort rätt!
            Rackethall hall = new Rackethall(8, 16);
            hall.Spela(new Person("Hasse"), 4);
            hall.Spela(new Person("Hasse"), 5);
            hall.Spela(new Person("David"), 6);
            Assert.AreEqual(13, hall.LedigaPlatser());
            Assert.IsTrue(hall.KontrolleraBanor());
            hall.Spela(new Person("Marcus"), 12);
            Assert.AreEqual(12, hall.LedigaPlatser());
            Assert.IsFalse(hall.KontrolleraBanor());
        }
    }
}
