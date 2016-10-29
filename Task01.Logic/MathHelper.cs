using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Task01.Logic
{
    public static class MathHelper
    {
        #region public API
        public enum AlgorithmGcd
        {
            Euclidean,Binary
        } 

        public static int GCD(AlgorithmGcd algorithm,params int[] data)
        {
            return algorithm == AlgorithmGcd.Euclidean ? data.Aggregate(EuclideanGCD) : data.Aggregate(BinaryGCD);
        }

        public static int GCD(AlgorithmGcd algorithm,out TimeSpan algorithmTime,params int[] data)
        {
            Stopwatch watcher = new Stopwatch();
            int gcdResult = 0;
            watcher.Start();
            gcdResult = algorithm == AlgorithmGcd.Euclidean ? data.Aggregate(EuclideanGCD) : data.Aggregate(BinaryGCD);
            watcher.Stop();
            algorithmTime = watcher.Elapsed;
            return gcdResult;
        }

        #endregion

        #region private GCD algorithms Euclidean and Binary

        private static int EuclideanGCD(int a, int b)
        {
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

        private static int BinaryGCD(int a, int b)
        {
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
