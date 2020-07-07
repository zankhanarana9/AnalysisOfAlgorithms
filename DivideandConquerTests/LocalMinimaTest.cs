using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace DivideAndConquerTests
{
    [TestClass]
    public class LocalMinimaTest
    {
        [TestMethod]
        public void LocalMinimaTest1()
        {
            int[,] matrix = new int[,]
            {
                {8,8,10,11 },
                {9,3,6,4 },
                {10,7,12,21 },
                {15,20,11,81 }
            };

            int res = LocalMinima.FindLocalMinimum(matrix);
            int expected = 3;
            Assert.AreEqual(expected, res);
        }
    }
}
