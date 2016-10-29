using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic
{
    public static class ArrayToolsExtension
    {

        private static Func<int[], int> criteria;

        public enum Order
        {
            Increase = 1,
            Decrease = -1
        }

        public enum SortingCreteria
        {
            SumOfRowElem, MaxRowElem, MinRowElem
        }

        public static void BubbleSort(this int[][] data, SortingCreteria sortCriteria, Order order)
        {
            switch (sortCriteria)
            {
                case SortingCreteria.SumOfRowElem:
                    criteria = (a) => (a.Sum());
                    break;
                case SortingCreteria.MaxRowElem:
                    criteria = (a) => (a.Max());
                    break;
                case SortingCreteria.MinRowElem:
                    criteria = (a) => (a.Min());
                    break;
            }
            BubbleSort(data, order);
        }

        private static void BubbleSort(int[][] data, Order order)
        {

            int i = 0;
            bool t = true;
            while (t)
            {
                t = false;
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (CompareCriteria(data[j], data[j + 1],order) > 0)
                    {
                        Swap(ref data[j], ref data[j + 1]);
                        t = true;
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

        private static int CompareCriteria(int[] a, int[] b,Order order)
        {
            if (criteria(a) > criteria(b))
            {
                return 1*(int)order;
            }
            if (criteria(a) < criteria(b))
            {
                return -1*(int)order;
            }
            else
            {
                return 0;
            }
        }
    }
}

