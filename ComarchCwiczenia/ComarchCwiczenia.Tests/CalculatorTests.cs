using ComarchCwiczenia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddShouldReturnValidSumValue()
        {
            // zasada A A A
            // Arrange
            int x = 2, y = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            //Act

            int actual = calculator.Add(x, y);

            //Assert

            //TIP: można użyć biblioteki FluentAssertion

            Assert.AreEqual(expected, actual);
        }
    }
}