using Microsoft.VisualStudio.TestTools.UnitTesting;
using FF3_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace FF3_2.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void WeekdayTest()
        {
            Assert.AreEqual(Program.Weekday(2), "Tuesday");

            // Testar så att det faktiskt blir en Exception när man stoppar in ett felaktigt värde i Weekdays
            Assert.ThrowsException<ArgumentException>(() => Program.Weekday(8));
        }


        [TestMethod()]
        public void SorteraTest()
        {
            var a = new int[] { 2, 3, 1 };
            Program.Sortera(a);
            CollectionAssert.AreEqual(a, new int[] { 1, 2, 3 });

            var a2 = new int[] { 2, 3, 4, 1, 5 };
            Program.Sortera(a2);
            CollectionAssert.AreEqual(a2, new int[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(a2[4], 5);

            var a3 = new int[0];
            Program.Sortera(a3);
            CollectionAssert.AreEqual(a3, new int[0]);

            


        }
    }
}