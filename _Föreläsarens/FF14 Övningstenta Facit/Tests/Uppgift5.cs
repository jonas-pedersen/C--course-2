using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class Konstig
    {
        public int Kör(int y)
        {
            return (y + 3) * 4;
        }
    }


    [TestClass]
    public class Uppgift5
    {
        [TestMethod]
        public void Uppg()
        {
            // (6p)

            // Studera metoden Kör i klassen Konstig.
            // Förenkla metoden och klassen så mycket som möjligt
            // så länge som den fortfarande alltid ger samma resultat som förut.

            // Lägg till fler test nedan om det hjälper.

            var konstig = new Konstig();
            Assert.AreEqual(20, konstig.Kör(2));
        }
    }
}
