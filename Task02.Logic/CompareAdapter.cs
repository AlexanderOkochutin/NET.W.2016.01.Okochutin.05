using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic
{
    /// <summary>
    /// compare-adapter based on delegate-comparator or comparator
    /// </summary>
    class CompareAdapter : IComparer<int[]>
    {
        /// <summary>
        /// criteria of sort 
        /// </summary>
        private readonly Func<int[], int[], int> compareCriteria;

        #region Constructors

        public CompareAdapter(Func<int[], int[], int> compareCriteria)
        {
            this.compareCriteria = compareCriteria;
        }

        public CompareAdapter(IComparer<int[]> compareCriteria)
        {
            this.compareCriteria = compareCriteria.Compare;
        }

        #endregion

        /// <summary>
        /// private methods of compare of two arrays of integer based on compareCriteria
        /// </summary>
        /// <returns> -1 , 0, 1 </returns>
        public int Compare(int[] x, int[] y)
        {
            return compareCriteria(x, y);
        }
    }
}
