using System;
using Task02.Logic;
using NUnit.Framework;
using Task02.Logic;

namespace Task02.NUnitTests
{
    [TestFixture]
    public class ArrayToolsExtensionTests
    {
       public int[][] TestData1 = new int[][] 
        {
            new int[]{1,2},
            new int[]{1,2,3},
            new int[] {1,2,3,4},
            new int[] {1,2,3,4,5},
            new int[] {1,2,3,4,5,6},
            new int[] {1,2,3,4,5,6,7}
        };

        private int[][] ExpectedData1 = new int[][]
        {
            new int[] {1, 2, 3, 4, 5, 6, 7},
            new int[] {1, 2, 3, 4, 5, 6},
            new int[] {1, 2, 3, 4, 5},
            new int[] {1, 2, 3, 4},
            new int[] {1, 2, 3},
            new int[] {1, 2}
        };

        public int[][] TestData2 = new int[][]
        {
            new int[] {12, 24},
            new int[] {11, 2, 3},
            new int[] {10, -22, -3, 4},
            new int[] {15, 2, 3, 4, 5},
            new int[] {10, 2, 23, 4, -5, 6},
            new int[] {14, 32, 3, 4, 5, 6, 7}
        };

        public int[][] ExpectedData2 = new int[][]
        {
            new int[] {10, -22, -3, 4},
            new int[] {11, 2, 3},
            new int[] {15, 2, 3, 4, 5},
            new int[] {12, 24},
            new int[] {10, 2, 23, 4, -5, 6},
            new int[] {14, 32, 3, 4, 5, 6, 7}
        };

        public int[][] TestData3 = new int[][]
        {
            new int[] {12, 24},
            new int[] {11, 2, 3},
            new int[] {10, -22, -3, 4},
            new int[] {15, 2, 3, 4, 5},
            new int[] {10, 2, 23, 4, -5, 6},
            new int[] {14, 32, 3, 4, 5, 6, 7}
        };

        public int[][] ExpectedData3 = new int[][]
        {
            new int[] {10, -22, -3, 4},
            new int[] {10, 2, 23, 4, -5, 6},
            new int[] {11, 2, 3},
            new int[] {15, 2, 3, 4, 5},
            new int[] {14, 32, 3, 4, 5, 6, 7},
            new int[] {12, 24}
            
        };
        [Test]
        public void BubbleSort_TestData1_ExpectedData1()
        {
            TestData1.BubbleSort(ArrayToolsExtension.SortingCreteria.MaxRowElem, ArrayToolsExtension.Order.Decrease);
            CollectionAssert.AreEqual(TestData1,ExpectedData1);
        }

        [Test]
        public void BubbleSort_TestData2_ExpectedData2()
        {
            TestData2.BubbleSort(ArrayToolsExtension.SortingCreteria.SumOfRowElem, ArrayToolsExtension.Order.Increase);
            CollectionAssert.AreEqual(TestData2, ExpectedData2);
        }

        [Test]
        public void BubbleSort_TestData3_ExpectedData3()
        {
            TestData3.BubbleSort(ArrayToolsExtension.SortingCreteria.MinRowElem, ArrayToolsExtension.Order.Increase);
            CollectionAssert.AreEqual(TestData3, ExpectedData3);
        }
    }
}
