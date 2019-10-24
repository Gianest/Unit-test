using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;
using NUnit.Framework;

namespace unittest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calculator;
        [SetUp]
        public void init()
        {
            calculator = new Calculator();
        }
        [Test]
        public void PerkalianTest()
        {
            Assert.AreEqual(10, calculator.Perkalian(5, 2));
        }
    }
}
