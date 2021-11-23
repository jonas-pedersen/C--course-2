using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Tests
{
    [TestClass]
    public class Uppgift4
    {
        enum Mood { Happy, Neutral, Sad };

        bool GoodString(string s, Mood m)
        {
            if (m == Mood.Sad)
            {
                throw new ArgumentException(":(");
            }
            if (m == Mood.Neutral)
            {
                if (s.Length < 10)
                {
                    throw new Exception(":/");
                }
            }
            if (s == "MARCUS" || s.Length > 7)
            {
                return true;
            }
            return false;
        }

        [TestMethod]
        public void Uppg()
        {
            // (6p)

            // Fyll i metoden GoodString ovan. Den ska ta två argument: en sträng och en Mood (se rad 12),
            // Om Mood-argumentet är Sad ska metoden alltid kasta en valfri Exception.
            // Om Mood-argumentet är Neutral ska metoden kasta en Exception om strängen är kortare än 10 tecken.
            // I övrigt returnerar metoden true om strängen är "MARCUS" eller längre än 7 bokstäver. Annars false.

            // Kommentera ut följande tester för att kontrollera om du gjort rätt!
            Assert.ThrowsException<ArgumentException>(() => GoodString("MARCUS", Mood.Sad));
            Assert.IsTrue(GoodString("1234567890A", Mood.Neutral));
            Assert.IsFalse(GoodString("MARABOU", Mood.Happy));
        }
    }
}
