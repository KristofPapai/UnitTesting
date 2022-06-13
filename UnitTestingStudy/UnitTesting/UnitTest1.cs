using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_5kgAlatt()
        {
            AlmaPiac piac = new AlmaPiac();
            double egysegAr = 400;
            double expected = egysegAr;
            double actual = piac.GetAlmaAr(1.0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_5kgFel20Alatt() {
            AlmaPiac piac = new AlmaPiac();
            double egysegAr = 400;
            double expected = (egysegAr * 5.0)*0.9;
            double actual = piac.GetAlmaAr(5.0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_20felett()
        {
            AlmaPiac piac = new AlmaPiac();
            double egysegAr = 400;
            double expected = (egysegAr * 20.0) * 0.85;
            double actual = piac.GetAlmaAr(20.0);
            Assert.AreEqual(expected, actual);
        }
    }
}
