using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanGCD
{
    /// <summary>
    /// Class that implements Euclidean algorithm
    /// </summary>
    public static class EuclideanGCD
    {
        /// <summary>
        /// Method that calculate a greatest common divisor for two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GetGCD(int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException();

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers
        /// </summary>
        /// <param name="numbers">numbers, count should be two or more</param>
        public static int GetGCD(params int[] numbers)
        {
            if (numbers.Length == 0 || numbers.Length == 1)
                throw new ArgumentException();

            int tmpGCD = GetGCD(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                tmpGCD = GetGCD(tmpGCD, numbers[i]);
            }

            return tmpGCD;
        }
    }
}
