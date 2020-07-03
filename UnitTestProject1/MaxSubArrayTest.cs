using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace DivideAndConquerTests
{
    [TestClass]
    public class MAxSubArrayTest
    {
        [TestMethod]
        public void MaxSubArrayTest1()
        {
            int[] array = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            MaxSubArray ms = new MaxSubArray();
            int actual = ms.Max(array);
            int expected = 6;
            Assert.AreEqual(actual, expected);
        }
    }
}
