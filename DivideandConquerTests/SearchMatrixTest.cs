using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace DivideAndConquerTests
{
    [TestClass]
    public class SearchMatrixTest
    {
        [TestMethod]
        public void SearchMatrixTest1()
        {
            int[,] matrix = new int[,]
            {
                {-1,3}               
            };
            bool actual = SearchInMatrix.SearchMatrix(matrix, 20);
        }
    }
}
