using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Task01.Logic
{
    /// <summary>
    /// Extension math tools
    /// </summary>
    public static class MathHelper
    {
        #region public API 

        /// <summary>
        /// Type of GCD algorithm
        /// </summary>
        public enum AlgorithmGcd
        {
            Euclidean,Binary
        }

        /// <summary>
        /// Get Greatest Common Divisior method
        /// </summary>
        /// <param name="algorithm"> one of two algoritms from service Enum</param>
        /// <param name="data">input int numbers</param>
        /// <returns>GCD of all input numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int GCD(AlgorithmGcd algorithm,params int[] data)
        {
            if (algorithm != AlgorithmGcd.Binary && algorithm != AlgorithmGcd.Euclidean)
            {
                throw  new ArgumentException("number of algorithm is not valid",nameof(algorithm));
            }

            return algorithm == AlgorithmGcd.Euclidean ? data.Aggregate(EuclideanGCD) : data.Aggregate(BinaryGCD);
        }

        /// <summary>
        /// Get Greatest Common Divisior method with time check
        /// </summary>
        /// <param name="algorithm">one of two algoritms from service Enum</param>
        /// <param name="algorithmTime">TimeSpan of algorithm running</param>
        /// <param name="data">input int numbers</param>
        /// <returns>GCD of all input numbers</returns>
        /// <exception cref="OverflowException"> throw when one of numbers equal int.minvalue</exception>
        /// <exception cref="ArgumentException"> throw when two neighbours are zero or when number of algoritm is not valid</exception>
        public static int GCD(AlgorithmGcd algorithm,out TimeSpan algorithmTime,params int[] data)
        {
            if (algorithm != AlgorithmGcd.Binary && algorithm != AlgorithmGcd.Euclidean)
            {
                throw new ArgumentException("number of algorithm is not valid", nameof(algorithm));
            }

            Stopwatch watcher = new Stopwatch();
            int gcdExpected = 0;
            watcher.Start();
            gcdExpected = algorithm == AlgorithmGcd.Euclidean ? data.Aggregate(EuclideanGCD) : data.Aggregate(BinaryGCD);
            watcher.Stop();
            algorithmTime = watcher.Elapsed;
            return gcdExpected;
        }

        #endregion

        #region private GCD algorithms Euclidean and Binary
        /// <summary>
        /// Euclidean GCD algorithm
        /// </summary>
        private static int EuclideanGCD(int a, int b)
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
        private static int BinaryGCD(int a, int b)
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
