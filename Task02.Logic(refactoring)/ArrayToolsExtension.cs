using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic_refactoring_
{
    /// <summary>
    /// Static class for extension array functionality
    /// </summary>
    public static class ArrayToolsExtension
    {
        /// <summary>
        /// Bubble sort of rows in jagged  array of integer
        /// </summary>
        /// <param name="data">input jagged array of integer</param>
        /// <param name="comparer">criteria of sort (sum of elements in Row for example)</param>
        /// <exception cref="ArgumentNullException"> throw if input array or one of the row in input array is null</exception>
        public static void BubbleSort(this int[][] data, IComparer comparer)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            int i = 0;
            int count = 0;
            bool tryAgain = true;

            #region move null elements to the end
            for (int j = 0; j < data.Length; j++)
            {
                if (data[j] != null)
                    data[count++] = data[j];
            }

            for (int j = count; j < data.Length; j++)
            {
                data[j] = null;
            }
            #endregion

            #region bubble sort algorithm
            while (tryAgain)
            {
                tryAgain = false;
                for (int j = 0; j < count - i - 1; j++)
                {

                    if (comparer.Compare(data[j], data[j + 1]) > 0)
                    {
                        Swap(ref data[j], ref data[j + 1]);
                        tryAgain = true;
                    }
                }
                i++;
            }
            #endregion
        }

        /// <summary>
        /// Swap rows in jagged array
        /// </summary>
        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] c = a;
            a = b;
            b = c;
        }
    }
}
