using Microsoft.VisualStudio.TestTools.UnitTesting;
using FF6_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace FF6_2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetIntTest()
        {
            Assert.AreEqual(10, Program.GetInt("10"));

            Assert.ThrowsException<FormatException>(() => Program.GetInt("abcdef"));



            // Ger rött, kastar ingen exception:
            // Assert.ThrowsException<FormatException>(() => Program.GetInt("123456"));
        }

        [TestMethod()]
        public void PunktTest()
        {
            Punkt p = new Punkt(2, 3);

            int xy = p.XplusY();

            Assert.AreEqual(5, xy);

            Punkt q = Punkt.Copy(p);

        }

        [TestMethod()]
        public void GiltigtMenyvalTest()
        {
            Assert.ThrowsException<FormatException>(() => Program.GiltigtMenyval("INTE ETT MENYVAL"));
            Program.GiltigtMenyval("plus");
            Program.GiltigtMenyval("minus");
        }
    }
}