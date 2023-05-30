using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Modul_16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Multiplicaation_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Miltiplication(4, 10) == 40);
        }
        [Test]
        public  void Multiplication_MustThrowExeption()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<ArgumentException>(() => calculator.Miltiplication(1.1, 2.2));
        }

        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Additional(8, 2) == 10);
        }

        [Test]
        public void Substruction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Substraction(300,10) == 290);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(10,3) == 3);
        }
        [Test]
        public void Division_MustThrowExeption()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
