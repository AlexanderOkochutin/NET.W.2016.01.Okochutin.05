using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Logic;

namespace Task02.NUnitTests
{
    class SumIncComparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.Sum() > b.Sum())
            {
                return 1;
            }
            if (a.Sum() < b.Sum())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class SumDecComparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.Sum() < b.Sum())
            {
                return 1;
            }
            if (a.Sum() > b.Sum())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class MaxElemIncComparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.Max() > b.Max())
            {
                return 1;
            }
            if (a.Max() < b.Max())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class MaxElemDecComparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a.Max() < b.Max())
            {
                return 1;
            }
            if (a.Max() > b.Max())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
