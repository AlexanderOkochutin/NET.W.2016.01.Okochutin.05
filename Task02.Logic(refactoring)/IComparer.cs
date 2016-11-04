using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic_refactoring_
{
    public interface IComparer
    {
        int Compare(int[] a, int[] b);
    }
}
