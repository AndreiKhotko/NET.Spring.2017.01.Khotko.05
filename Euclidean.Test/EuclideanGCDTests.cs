using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EuclideanGCD.Test
{
    [TestFixture]
    public class EuclideanGCDTests
    {
        private long timeExecution;

        [TestCase()]
        public void GetGCD_TakesZeroParameters_ThrowArgumentCountException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(out timeExecution));
        }

        [TestCase(1)]
        public void GetGCD_TakesOneParameter_ThrowArgumentCountException(int a)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(out timeExecution, a));
        }

        [TestCase(2, 4, ExpectedResult = 2)]
        [TestCase(30, 10, ExpectedResult = 10)]
        public int GetGCD_TakesTwoParameters_PositiveTest(int a, int b)
        {
            return EuclideanGCD.GetGCD(out timeExecution, a, b);
        }

        [TestCase(5, 10, 15, ExpectedResult = 5)]
        [TestCase(30, 2, 15, ExpectedResult = 1)]
        [TestCase(2, 4, 6, 10, 8, ExpectedResult = 2)]
        [TestCase(9, 3, 18, 30, 90, ExpectedResult = 3)]
        public int GetGCD_TakesMoreThanTwoParameters_PositiveTest(params int[] numbers)
        {
            return EuclideanGCD.GetGCD(out timeExecution, numbers);
        }

        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(1, 2, 0, ExpectedResult = 1)]
        public int GetGCD_TakesZero_PositiveTest(params int[] numbers)
        {
            return EuclideanGCD.GetGCD(out timeExecution, numbers);
        }

        [TestCase(0, 0)]
        [TestCase(0, 0, 0)]
        public void GetGCD_TakesAllZero_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(out timeExecution, numbers));
        }

        [TestCase(5, -10, 15)]
        [TestCase(-30, 2, 15)]
        public void GetGCD_TakesNegativeNumber_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(out timeExecution, numbers));
        }

        [TestCase()]
        public void BinaryGCD_TakesZeroParameters_ThrowArgumentCountException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(out timeExecution));
        }

        [TestCase(1)]
        public void BinaryGCD_TakesOneParameter_ThrowArgumentCountException(int a)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(out timeExecution, a));
        }

        [TestCase(2, 4, ExpectedResult = 2)]
        [TestCase(30, 10, ExpectedResult = 10)]
        public int BinaryGCD_TakesTwoParameters_PositiveTest(int a, int b)
        {
            return EuclideanGCD.BinaryGCD(out timeExecution, a, b);
        }

        [TestCase(5, 10, 15, ExpectedResult = 5)]
        [TestCase(30, 2, 15, ExpectedResult = 1)]
        [TestCase(2, 4, 6, 10, 8, ExpectedResult = 2)]
        [TestCase(9, 3, 18, 30, 90, ExpectedResult = 3)]
        public int BinaryGCD_TakesMoreThanTwoParameters_PositiveTest(params int[] numbers)
        {
            return EuclideanGCD.BinaryGCD(out timeExecution, numbers);
        }

        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(1, 2, 0, ExpectedResult = 1)]
        public int BinaryGCD_TakesZero_PositiveTest(params int[] numbers)
        {
            return EuclideanGCD.BinaryGCD(out timeExecution, numbers);
        }

        [TestCase(0, 0)]
        [TestCase(0, 0, 0)]
        public void BinaryGCD_TakesAllZero_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(out timeExecution, numbers));
        }

        [TestCase(5, -10, 15)]
        [TestCase(-30, 2, 15)]
        public void BinaryGCD_TakesNegativeNumber_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(out timeExecution, numbers));
        }
    }
}
