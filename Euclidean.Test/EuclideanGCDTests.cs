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
        [TestCase()]
        public void GetGCD_TakesZeroParameters_ThrowsArgumentCountException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD());
        }

        [TestCase(1, ExpectedResult = 1)]
        public int GetGCD_TakesOneParameter_ReturnsTheValueOfParameter(int a)
        {
            return EuclideanGCD.GetGCD(a);
        }

        [TestCase(2, 4, ExpectedResult = 2)]
        [TestCase(30, 10, ExpectedResult = 10)]
        public int GetGCD_TakesTwoParameters_PositiveTest(int a, int b)
        {
            return EuclideanGCD.GetGCD(a, b);
        }

        [TestCase(2, 4, 6, ExpectedResult = 2)]
        [TestCase(30, 10, 15, ExpectedResult = 5)]
        public int GetGCD_TakesThreeParameters_PositiveTest(int a, int b, int c)
        {
            return EuclideanGCD.GetGCD(a, b, c);
        }

        [TestCase(2, 4, 6, 8, ExpectedResult = 2)]
        [TestCase(30, 10, 15, 45, ExpectedResult = 5)]
        public int GetGCD_TakesFourParameters_PositiveTest(int a, int b, int c, int d)
        {
            return EuclideanGCD.GetGCD(a, b, c, d);
        }

        [TestCase(5, 10, 15, 20, 25, ExpectedResult = 5)]
        [TestCase(2, 4, 6, 10, 8, ExpectedResult = 2)]
        [TestCase(9, 3, 18, 30, 90, 33, 99, 24, ExpectedResult = 3)]
        public int GetGCD_TakesMoreThanFourParameters_PositiveTest(params int[] numbers)
        {
            return EuclideanGCD.GetGCD(numbers);
        }

        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 5, ExpectedResult = 5)]
        public int GetGCD_TakesZero_PositiveTest(int a, int b)
        {
            return EuclideanGCD.GetGCD(a, b);
        }

        [TestCase(0, 0)]
        public void GetGCD_TakesAllZero_ThrowsArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(a, b));
        }

        [TestCase(0, 0, 0, 0, 0)]
        public void GetGCD_TakesParamsAllZero_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(numbers));
        }

        [TestCase(0, 0, 0, 0, 1)]
        public void GetGCD_TakesOneNotZeroParamAndOtherZeros_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(numbers));
        }

        [TestCase(5, -10, 15)]
        [TestCase(-30, 2, 15)]
        public void GetGCD_TakesNegativeNumber_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.GetGCD(numbers));
        }

        [TestCase()]
        public void BinaryGCD_TakesZeroParameters_ThrowsArgumentCountException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD());
        }

        [TestCase(1, ExpectedResult = 1)]
        public int BinaryGCD_TakesOneParameter_ReturnsTheValueOfParameter(int a)
        {
            return EuclideanGCD.BinaryGCD(a);
        }

        [TestCase(2, 4, ExpectedResult = 2)]
        [TestCase(30, 10, ExpectedResult = 10)]
        public int BinaryGCD_TakesTwoParameters_PositiveTest(int a, int b)
        {
            return EuclideanGCD.BinaryGCD(a, b);
        }

        [TestCase(2, 4, 6, ExpectedResult = 2)]
        [TestCase(30, 10, 15, ExpectedResult = 5)]
        public int BinaryGCD_TakesThreeParameters_PositiveTest(int a, int b, int c)
        {
            return EuclideanGCD.BinaryGCD(a, b, c);
        }

        [TestCase(2, 4, 6, 8, ExpectedResult = 2)]
        [TestCase(30, 10, 15, 45, ExpectedResult = 5)]
        public int BinaryGCD_TakesFourParameters_PositiveTest(int a, int b, int c, int d)
        {
            return EuclideanGCD.BinaryGCD(a, b, c, d);
        }

        [TestCase(5, 10, 15, 20, 25, ExpectedResult = 5)]
        [TestCase(2, 4, 6, 10, 8, ExpectedResult = 2)]
        [TestCase(9, 3, 18, 30, 90, 33, 99, 24, ExpectedResult = 3)]
        public int BinaryGCD_TakesMoreThanFourParameters_PositiveTest(params int[] numbers)
        {
            return EuclideanGCD.BinaryGCD(numbers);
        }

        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 5, ExpectedResult = 5)]
        public int BinaryGCD_TakesZero_PositiveTest(int a, int b)
        {
            return EuclideanGCD.BinaryGCD(a, b);
        }

        [TestCase(0, 0)]
        public void BinaryGCD_TakesAllZero_ThrowsArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(a, b));
        }

        [TestCase(0, 0, 0, 0, 0)]
        public void BinaryGCD_TakesParamsAllZero_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(numbers));
        }

        [TestCase(0, 0, 0, 0, 1)]
        public void BinaryGCD_TakesOneNotZeroParamAndOtherZeros_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(numbers));
        }

        [TestCase(5, -10, 15)]
        [TestCase(-30, 2, 15)]
        public void BinaryGCD_TakesNegativeNumber_ThrowsArgumentException(params int[] numbers)
        {
            Assert.Throws<ArgumentException>(() => EuclideanGCD.BinaryGCD(numbers));
        }

    }
}
