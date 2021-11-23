using Microsoft.VisualStudio.TestTools.UnitTesting;
using F16;
using System;
using System.Collections.Generic;
using System.Text;

namespace F16.Tests
{
    [TestClass()]
    public class BilTests
    {

        [TestMethod()]
        public void CykelTest()
        {
            Cykel cykel = new Cykel();
            Assert.AreEqual(0, cykel.Hastighet);
            cykel.Gasa();
            Assert.AreEqual(0.5f, cykel.Hastighet);
            cykel.Bromsa();
            Assert.AreEqual(0, cykel.Hastighet);
            cykel.Bromsa();
            Assert.AreEqual(0, cykel.Hastighet);
        }

        [TestMethod()]
        public void BilTest()
        {
            Volvo volvo = new Volvo();
            Assert.AreEqual(0, volvo.Hastighet);
            volvo.Gasa();
            Assert.AreEqual(3.5f, volvo.Hastighet);
            volvo.Bromsa();
            Assert.AreEqual(0, volvo.Hastighet);
            volvo.Bromsa();
            Assert.AreEqual(0, volvo.Hastighet);
        }
    }
}