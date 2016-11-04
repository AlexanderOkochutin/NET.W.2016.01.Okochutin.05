using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Logic_refactoring_;

namespace Task02.NUnitTests
{
    class SumIncComparer : IComparer
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

    class SumDecComparer : IComparer
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

    class MaxElemIncComparer : IComparer
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

    class MaxElemDecComparer : IComparer
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
