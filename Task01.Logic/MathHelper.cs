using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Task01.Logic
{
    public static class MathHelper
    {
        #region EuclideanGCD overloaded methods
        /// <summary>
        /// Euclidean algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a"> first int number</param>
        /// <param name="b"> second int number</param>
        /// <returns> greatest common divisior of first and second number</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int EuclideanGCD(int a, int b) => GCD(a, b, Euclidean);


        /// <summary>
        /// Euclidean algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a">first int number</param>
        /// <param name="b">second int number</param>
        /// <param name="c">third int number</param>
        /// <returns>common divisior of given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int EuclideanGCD(int a, int b, int c) => GCD(a, b, c, Euclidean);


        /// <summary>
        /// Euclidean algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="data">input array of int</param>
        /// <returns>greatest common divisir of all given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid, or length of input array less than 2</exception>
        /// <exception cref="ArgumentNullException"> throw when input array is null</exception>
        public static int EuclideanGCD(params int[] data) => GCD(Euclidean, data);
        

        /// <summary>
        /// Euclidean algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a"> first int number</param>
        /// <param name="b"> second int number</param>
        /// <param name="time">time of algorithm running</param>
        /// <returns> greatest common divisior of first and second number</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int EuclideanGCD(int a, int b, out long time) => GCD(a, b, Euclidean, out time);


        /// <summary>
        /// Euclidean algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a">first int number</param>
        /// <param name="b">second int number</param>
        /// <param name="c">third int number</param>
        /// <param name="time"> time of running algorithm</param>
        /// <returns>common divisior of given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int EuclideanGCD(int a, int b, int c, out long time) => GCD(a, b, c, Euclidean, out time);


        /// <summary>
        /// Euclidean algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="data">input array of int</param>
        /// <param name="time">time of running algorithm</param>
        /// <returns>greatest common divisir of all given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid, or length of input array less than 2</exception>
        /// <exception cref="ArgumentNullException"> throw when input array is null</exception>
        public static int EuclideanGCD(out long time, params int[] data) => GCD(Euclidean, out time, data);


        #endregion

        #region BinaryGCD overloaded methods
        /// <summary>
        /// Binary algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a"> first int number</param>
        /// <param name="b"> second int number</param>
        /// <returns> greatest common divisior of first and second number</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int BinaryGCD(int a, int b) => GCD(a, b, Binary);


        /// <summary>
        /// Binary algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a">first int number</param>
        /// <param name="b">second int number</param>
        /// <param name="c">third int number</param>
        /// <returns>common divisior of given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int BinaryGCD(int a, int b, int c) => GCD(a, b, c, Binary);


        /// <summary>
        /// Binary algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="data">input array of int</param>
        /// <returns>greatest common divisir of all given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid, or length of input array less than 2</exception>
        /// <exception cref="ArgumentNullException"> throw when input array is null</exception>
        public static int BinaryGCD(params int[] data)=> GCD(Binary, data);


        /// <summary>
        /// Binary algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a"> first int number</param>
        /// <param name="b"> second int number</param>
        /// <param name="time">time of algorithm running</param>
        /// <returns> greatest common divisior of first and second number</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int BinaryGCD(int a, int b, out long time) => GCD(a, b, Binary, out time);


        /// <summary>
        /// Binary algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="a">first int number</param>
        /// <param name="b">second int number</param>
        /// <param name="c">third int number</param>
        /// <param name="time"> time of running algorithm</param>
        /// <returns>common divisior of given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int BinaryGCD(int a, int b, int c, out long time) => GCD(a, b, c, Binary, out time);

    
        /// <summary>
        /// Binary algorithm of finding greatest common divisior
        /// </summary>
        /// <param name="data">input array of int</param>
        /// <param name="time">time of running algorithm</param>
        /// <returns>greatest common divisir of all given numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid, or length of input array less than 2</exception>
        /// <exception cref="ArgumentNullException"> throw when input array is null</exception>
        public static int BinaryGCD(out long time, params int[] data) => GCD(Binary, out time, data);


        #endregion

        #region private AlgorithmCallers

        private static int GCD(int a, int b, Func<int, int, int> algorithm) => algorithm(a, b);

        private static int GCD(int a, int b, int c, Func<int, int, int> algorithm) => algorithm(algorithm(a, b), c);

        private static int GCD(Func<int, int, int> algorithm, params int[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            if (data.Length < 2)
            {
                throw new ArgumentException("input array length must be more than 1", nameof(data));
            }
            return data.Aggregate(algorithm);
        }

        private static int GCD(int a, int b, Func<int, int, int> algorithm, out long time)
        {
            Stopwatch watcher = new Stopwatch();
            watcher.Start();
            int result = GCD(a, b, algorithm);
            watcher.Stop();
            time = watcher.Elapsed.Ticks;
            return result;
        }

        private static int GCD(int a, int b, int c, Func<int, int, int> algorithm, out long time)
        {
            Stopwatch watcher = new Stopwatch();
            watcher.Start();
            int result = GCD(a, b, c, algorithm);
            watcher.Stop();
            time = watcher.Elapsed.Ticks;
            return result;
        }

        private static int GCD(Func<int, int, int> algorithm, out long time, params int[] data)
        {
            Stopwatch watcher = new Stopwatch();
            watcher.Start();
            int result = GCD(algorithm,data);
            watcher.Stop();
            time = watcher.Elapsed.Ticks;
            return result;
        }

        #endregion

        #region private GCD algorithms Euclidean and Binary
        /// <summary>
        /// Euclidean GCD algorithm
        /// </summary>
        private static int Euclidean(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("at least one number must be non zero");
            }

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        /// <summary>
        /// BInary GCD algorithm
        /// </summary>
        private static int Binary(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("at least one number must be non zero");
            }

            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                    return BinaryGCD(a >> 1, b);
                else
                    return BinaryGCD(a >> 1, b >> 1) << 1;
            }
            if ((~b & 1) != 0)
                return BinaryGCD(a, b >> 1);
            if (a > b)
                return BinaryGCD((a - b) >> 1, b);
            return BinaryGCD((b - a) >> 1, a);
        }

        #endregion
    }
}
