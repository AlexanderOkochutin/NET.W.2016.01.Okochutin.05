using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02.Logic
{
    /// <summary>
    /// Extension tools for int array
    /// </summary>
    /// 
    public static class ArrayToolsExtension
    {
        #region ServiceEnums
        /// <summary>
        /// Order of sort increase or decrease
        /// </summary>
        public enum Order
        {
            Increase = 1,
            Decrease = -1
        }

        /// <summary>
        /// Sorting Criteria, Sum of elements in rows, max or min element in row
        /// </summary>
        public enum SortingCreteria
        {
            SumOfRowElem, MaxRowElem, MinRowElem
        }

        #endregion

        #region BubbleSortAPI
        /// <summary>
        /// Bubble sort of rows in jagged array
        /// </summary>
        /// <param name="data">jagged array of int</param>
        /// <param name="sortCriteria">one of criteria from Service Enums SUM MIN MAX</param>
        /// <param name="order">one of order from Service Enums INC or DEC</param>
        /// <exception cref="OverflowException">when sort criteria is SUM put in block try-catch</exception>
        /// <exception cref="ArgumentException">when number of sort criteria or order is not valid</exception>
        public static void BubbleSort(this int[][] data, SortingCreteria sortCriteria, Order order)
        {
            if (order != Order.Decrease && order != Order.Increase)
            {
                throw new ArgumentException("order param is not valid",nameof(order));
            }
            switch (sortCriteria)
            {
                case SortingCreteria.SumOfRowElem:
                    BubbleSort(data,new Comparer((a) => (a.Sum()),order));
                    break;
                case SortingCreteria.MaxRowElem:
                    BubbleSort(data, new Comparer((a) => (a.Max()), order));
                    break;
                case SortingCreteria.MinRowElem:
                    BubbleSort(data, new Comparer((a) => (a.Min()), order));
                    break;
                default:
                    throw new ArgumentException("Sort criteria is not valid",nameof(sortCriteria));
                    break;
            }            
        }

        #endregion

        #region BubbleSortLogic

        private static void BubbleSort(int[][] data, Comparer comparer)
        {
            int i = 0;
            bool tryAgain = true;
            while (tryAgain)
            {
                tryAgain = false;
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (comparer.Compare(data[j], data[j + 1]) > 0)
                    {
                        Swap(ref data[j], ref data[j + 1]);
                        tryAgain = true;
                    }
                }
                i++;
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] c = a;
            a = b;
            b = c;
        }

        #endregion

        /// <summary>
        /// Comparer which take into constructor SortCriteria and Order from ServiceEnums
        /// </summary>
        private class Comparer : IComparer<int[]>
        {
            private readonly Func<int[], int> criteria;
            private readonly Order order;

            private Comparer() { }

            public Comparer(Func<int[], int> criteriaParam, Order orderParam)
            {
                criteria = criteriaParam;
                order = orderParam;
            }
            
            public int Compare(int[] x, int[] y)
            {
                if (criteria(x) > criteria(y))
                {
                    return 1 * (int)order;
                }
                if (criteria(x) < criteria(y))
                {
                    return -1 * (int)order;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

