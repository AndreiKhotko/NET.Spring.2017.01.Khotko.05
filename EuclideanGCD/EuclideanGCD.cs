using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// <param name="timeExecutionInMilliSeconds"></param>
        /// <returns></returns>
        private static int GetGCD(out long timeExecutionInMilliSeconds, int a, int b)
        {
            var watch = Stopwatch.StartNew();

            if (a < 0 || b < 0)
                throw new ArgumentException();

            if (a == 0 && b != 0)
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                return b;
            }

            if (b == 0 && a != 0)
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                return a;
            }

            if (a == 0 && b == 0)
                throw new ArgumentException();

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return a;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers
        /// </summary>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <param name="timeExecutionInMilliSeconds"></param>
        public static int GetGCD(out long timeExecutionInMilliSeconds, params int[] numbers)
        {
            var watch = Stopwatch.StartNew();

            if (numbers.Length == 0 || numbers.Length == 1)
                throw new ArgumentException();

            if (numbers.All(number => number == 0))
                throw new ArgumentException();

            long tmpTime;
            int tmpGCD = GetGCD(out tmpTime, numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                tmpGCD = GetGCD(out tmpTime, tmpGCD, numbers[i]);
            }

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return tmpGCD;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers using binary algorithm
        /// </summary>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <param name="timeExecutionInMilliSeconds"></param>
        private static int BinaryGCD(out long timeExecutionInMilliSeconds, int a, int b)
        {
            var watch = Stopwatch.StartNew();
            long tmp;

            if (a < 0 || b < 0)
                throw new ArgumentException();
            if (a == 0)
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                return b;
            }
            if (b == 0)
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                return a;
            }
            if (a == b)
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                return a;
            }
            if (a == 1 || b == 1)
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                return 1;
            }
            if ((a % 2 == 0) && (b % 2 == 0))
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

                return 2 * BinaryGCD(out tmp, a / 2, b / 2);
            }
            if ((a % 2 == 0) && (b % 2 != 0))
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                
                return BinaryGCD(out tmp, a / 2, b);
            }
            if ((a % 2 != 0) && (b % 2 == 0))
            {
                watch.Stop();
                timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;
                
                return BinaryGCD(out tmp, a, b / 2);
            }

            watch.Stop();
            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return BinaryGCD(out tmp, b, Math.Abs(a - b));
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers using binary algorithm
        /// </summary>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <param name="timeExecutionInMilliSeconds"></param>
        public static int BinaryGCD(out long timeExecutionInMilliSeconds, params int[] numbers)
        {
            var watch = Stopwatch.StartNew();

            if (numbers.Length == 0 || numbers.Length == 1)
                throw new ArgumentException();

            if (numbers.All(number => number == 0))
                throw new ArgumentException();

            long tmpTime;
            int tmpGCD = BinaryGCD(out tmpTime, numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                tmpGCD = BinaryGCD(out tmpTime, tmpGCD, numbers[i]);
            }

            watch.Stop();
            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return tmpGCD;
        }
    }
}
