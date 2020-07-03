using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace UnitTestProject1
{
    [TestClass]
    public class IndexSameAsValueTest
    {
        [TestMethod]
        public void IndexSameAsValueTest1()
        {
            int[] array = new int[] { -2, 0, 1, 2, 4, 8, 10 };
            bool actual = IndexSameAsValue.FindIndexSameAsValue(array);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
