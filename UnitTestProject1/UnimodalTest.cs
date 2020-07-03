using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnimodalTest
    {
        [TestMethod]
        public void UnimodalTest1()
        {
            int[] array = new int[] { 1, 3, 4, 5, 7, 8, 10, 12, 13, 14, 10, 9, 6, 2 };
            int actual = Unimodal.FindMaxUnimodal(array);
            int expected = 14;
            Assert.AreEqual(expected, actual);
        }
    }
}
