
using System;
using Xunit;

namespace Modul_16.Tests_1
{
    public class CalculatorTests
    {
        [Fact]
        public void Substruction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Substruction(100,50) == 50);
        }
        [Fact]
        public void Division_ReturnsCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(10,3) == 3);
        }
        [Fact]
        public void Division_MustThrowExeption()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
