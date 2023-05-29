using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Modul_16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Test1()
        {
            Assert.True(100 == 100);
        }
        [Test]
        public void Test2()
        {
            Assert.False(100 == 1001);
        }
        [Test]
        public void Substruction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Substruction(300,10) == 290);
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
