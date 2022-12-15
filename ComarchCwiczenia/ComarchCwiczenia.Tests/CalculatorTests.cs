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

        [TestMethod()]
        public void SubtractShouldReturnValidSubValue()
        {
            // Arrange
            int x = 3, y = 2;
            int expected = 1;
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyShouldReturnValidMultipliedValue()
        {
            // Arrange
            int x = 3, y = 2;
            int expected = 6;
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Multiply(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DividyShouldReturnValidDivisionValue()
        {
            // Arrange
            int x = 4, y = 2;
            float expected = 2;
            Calculator calculator = new Calculator();

            //Act
            float actual = calculator.Dividy(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DividyShouldThrowExceptionForZeroParameter()
        {
            // Arrange
            int x = 4, y = 0;
            Calculator calculator = new Calculator();

            //Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Dividy(x, y));
        }

        [TestMethod()]
        public void ModuloShouldReturnValidRemainderOfDivisionValue()
        {
            // Arrange
            int x = 3, y = 2;
            float expected = 1;
            Calculator calculator = new Calculator();

            //Act
            float actual = calculator.Modulo(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}