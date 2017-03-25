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
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException();
            if (a == 0 && b == 0)
                throw  new ArgumentException();

            if (a == 0 && b != 0) return b;
            if (b == 0 && a != 0) return a;
            
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
        /// Method that calculate a greatest common divisor for two numbers and timeExecution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">time execution of method</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(out long timeExecutionInMilliSeconds, int a, int b)
        {
            var watch = Stopwatch.StartNew();

            int result = GetGCD(a, b);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for three numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(int a, int b, int c)
        {
            return GetGCD(GetGCD(a, b), c);
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for three numbers and timeExecution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds"></param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(out long timeExecutionInMilliSeconds, int a, int b, int c)
        {
            var watch = Stopwatch.StartNew();

            int result = GetGCD(a, b, c);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for four numbers
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <param name="d">Four number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(int a, int b, int c, int d)
        { 
            return GetGCD(GetGCD(a, b, c), d);
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for four numbers and timeExecution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">time execution of method</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <param name="d">Four number</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(out long timeExecutionInMilliSeconds, int a, int b, int c, int d)
        {
            var watch = Stopwatch.StartNew();

            int result = GetGCD(a, b, c, d);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers
        /// </summary>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException();

            if (numbers.Length == 1)
                return numbers[0];

            if (numbers.All(number => number == 0))
                throw new ArgumentException();
            
            int tmpGCD = GetGCD(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                tmpGCD = GetGCD(tmpGCD, numbers[i]);
            }
            
            return tmpGCD;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers and timeExecution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">time execution of method</param>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <returns>Greatest common divisor</returns>
        public static int GetGCD(out long timeExecutionInMilliSeconds, params int[] numbers)
        {
            var watch = Stopwatch.StartNew();

            int result = GetGCD(numbers);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 numbers using binary algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException();
            if (a == 0 && b == 0)
                throw new ArgumentException();
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0))
                return 2 * BinaryGCD(a / 2, b / 2);

            if ((a % 2 == 0) && (b % 2 != 0))
                return BinaryGCD(a / 2, b);

            if ((a % 2 != 0) && (b % 2 == 0))
                return BinaryGCD(a, b / 2);

            return BinaryGCD(b, Math.Abs(a - b));
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 numbers using binary algorithm and determines time execution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">Time execution of method</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(out long timeExecutionInMilliSeconds, int a, int b)
        {
            var watch = Stopwatch.StartNew();

            int result = BinaryGCD(a, b);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 3 numbers using binary algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(int a, int b, int c)
        {
            return BinaryGCD(BinaryGCD(a, b), c);
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 3 numbers using binary algorithm and determines time execution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">Time execution of method</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(out long timeExecutionInMilliSeconds, int a, int b, int c)
        {
            var watch = Stopwatch.StartNew();

            int result = BinaryGCD(a, b, c);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 4 numbers using binary algorithm
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <param name="d">Fourth number</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(int a, int b, int c, int d)
        {
            return BinaryGCD(BinaryGCD(a, b, c), d);
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 4 numbers using binary algorithm and determines time execution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">Time execution of method</param>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        /// <param name="d">Fourth number</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(out long timeExecutionInMilliSeconds, int a, int b, int c, int d)
        {
            var watch = Stopwatch.StartNew();

            int result = BinaryGCD(a, b, c, d);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers using binary algorithm
        /// </summary>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException();

            if (numbers.Length == 1)
                return numbers[0];

            if (numbers.All(number => number == 0))
                throw new ArgumentException();

            int tmpGCD = BinaryGCD(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                tmpGCD = BinaryGCD(tmpGCD, numbers[i]);
            }

            return tmpGCD;
        }

        /// <summary>
        /// Method that calculate a greatest common divisor for 2 and more numbers and timeExecution of method
        /// </summary>
        /// <param name="timeExecutionInMilliSeconds">time execution of method</param>
        /// <param name="numbers">numbers, count should be two or more</param>
        /// <returns>Greatest common divisor</returns>
        public static int BinaryGCD(out long timeExecutionInMilliSeconds, params int[] numbers)
        {
            var watch = Stopwatch.StartNew();

            int result = BinaryGCD(numbers);

            watch.Stop();

            timeExecutionInMilliSeconds = watch.ElapsedMilliseconds;

            return result;
        }
    }
}
