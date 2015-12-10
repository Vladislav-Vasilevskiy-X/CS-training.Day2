using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static EuclidianAlg.Calculation;

namespace EuclidianAlg.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void GCD_OneParam_Param()
        {
            Assert.AreEqual(4, GCD(4));
        }

        [TestMethod]
        public void GCD_TwoParams_ParamsGCD()
        {
            Assert.AreEqual(6, GCD(18, 6));
        }

        [TestMethod]
        public void GCD_ThreeParams_ParamsGCD()
        {
            Assert.AreEqual(4, GCD(12, 24, 4));
        }

        [TestMethod]
        public void GCD_FourParams_ParamsGCD()
        {
            Assert.AreEqual(2, GCD(100, 2, 6, 8));
        }

        [TestMethod]
        public void GCDBinary_OneParam_Param()
        {
            Assert.AreEqual(4, GCD(4));
        }

        [TestMethod]
        public void GCDBinary_TwoParams_ParamsGCD()
        {
            Assert.AreEqual(6, GCD(18, 6));
        }

        [TestMethod]
        public void GCDBinary_ThreeParams_ParamsGCD()
        {
            Assert.AreEqual(4, GCD(12, 24, 4));
        }

        [TestMethod]
        public void GCDBinary_FourParams_ParamsGCD()
        {
            Assert.AreEqual(2, GCD(100, 2, 6, 8));
        }
    }
}
