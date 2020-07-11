using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace SortingAlgorithmsTest
{
    [TestClass]
    public class CountingSortTest
    {
        [TestMethod]
        public void CountingSortTest1()
        {
            int[] array = { 2, 5, 3, 0, 2, 3, 0, 3 };
            int[] result = CountingSort.Sort(array, 5);
            
        }
    }
}
