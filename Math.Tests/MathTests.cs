using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData(4,2,6)]
        [InlineData(6, 2, 8)]

        public void AddShouldReturnExpectedValue(int operator1,int operator2,int expected)
        {
            Calculations calc = new Calculations();
            int actual=calc.Add(operator1,operator2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(40, 2, 38)]
        public void SubstractShouldReturnExpectedValue(int operator1, int operator2, int expected)
        {
            Calculations calc = new Calculations();
            int actual = calc.Substract(operator1, operator2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]
        [InlineData(8, 2, 16)]
        public void MultiplyShouldReturnExpectedValue(int operator1, int operator2, int expected)
        {
            Calculations calc = new Calculations();
            int actual = calc.Multiply(operator1, operator2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(8, 2, 4)]

        public void DivideShouldReturnExpectedValue(int operator1, int operator2, int expected)
        {
            Calculations calc = new Calculations();
            int actual = calc.Divide(operator1, operator2);
            Assert.Equal(expected, actual);
        }

    }




}
