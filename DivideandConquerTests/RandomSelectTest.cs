using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace DivideAndConquerTests
{
    [TestClass]
    public class RandomSelectTest
    {
        [TestMethod]
        public void RandomSelectTest1()
        {
            int[] array = new int[] { 32, 17, 41, 18, 52, 98, 24, 65 };
            int k = RandomizedSelection.RandomSelect(array,0, array.Length-1, 4);
            int expected = 41;
            Assert.AreEqual(k, expected);
        }
    }
}
