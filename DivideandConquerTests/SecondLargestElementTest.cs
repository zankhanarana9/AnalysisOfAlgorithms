using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace UnitTestProject1
{
    [TestClass]
    public class SecondLargestElementTest
    {
        [TestMethod]
        public void SecondLargestElementTest1()
        {
            int[] array = new int[] { 8, 4, 2, 1,6,7,4,2,3,1 };
            int res = SecondLargestNumber.FindSecondLargestNumber(array);
            int actual = 8;
            Assert.AreEqual(res, actual);
        }
    }
}
