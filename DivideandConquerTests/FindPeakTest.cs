using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;
using System.Collections.Generic;

namespace DivideAndConquerTests
{
    [TestClass]
    public class FindPeakTest
    {
        [TestMethod]
        public void FindPeakTest1()
        {
            int[] matrix = new int[] { 55, 59, 63, 99, 97, 94, 84, 81, 79, 66, 40, 38, 33, 23, 22, 21, 17, 9, 7 };
            int expected = 8;
            int actual = FindPeaK.FindLocalMaximum(matrix);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void FindPeakTest2()
        //{
        //    int[] matrix = new int[] { 1, 2, 9, 8, 10, 4 };
        //    List<int> expected = new List<int>() { 9, 10 };
        //    List<int> actual = FindPeaK.FindAllPeak(matrix);
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
