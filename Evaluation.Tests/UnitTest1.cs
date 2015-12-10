using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Evaluation.Calculation;

namespace Evaluation.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void Evaluation_NegNumberPosPowerPosAccuracy_Zero()
        {
            Assert.AreEqual(0.0, Evaluate(-1, 2, 1));
        }

        [TestMethod]
        public void Evaluation_PosNumberPosPowerNegAccuracy_Zero()
        {
            Assert.AreEqual(0.0, Evaluate(2, 2, -1));
        }

        [TestMethod]
        public void Evaluation_PosNumberNegPowerPosAccuracy_Zero()
        {
            Assert.AreEqual(0.0, Evaluate(2, -2, 1));
        }

        [TestMethod]
        public void Evaluation_PosNumberPosPowerWriteAccuracy_Result()
        {
            Assert.AreEqual(2.0, Evaluate(8, 3, 0.000000000001));
        }

        [TestMethod]
        public void Evaluation_PosNumberPosPowerWrongAccuracy_Zero()
        {
            Assert.AreEqual(0.0, Evaluate(2, 3, 0));
        }

        [TestMethod]
        public void Evaluation_NegNumberEvenPowerWriteAccuracy_Result()
        {
            Assert.AreEqual(-2.0, Evaluate(-8, 3, 0.000000000001));
        }

        [TestMethod]
        public void Evaluation_NegNumberOddPowerWriteAccuracy_Zero()
        {
            Assert.AreEqual(0.0, Evaluate(-8, 4, 0.000000000001));
        }
    }
}
