using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;
using System.Collections.Generic;
using System.Linq;

namespace DivideAndConquerTests
{
    [TestClass]
    public class ClosestPairTest
    {
        [TestMethod]
        public void ClosestPairTest1()
        {
            List<Point> pts = new List<Point>()
            {
                new Point() {X =2, Y= 3},
                new Point() {X =12, Y= 30},
                new Point() {X =40, Y= 50},
                new Point() {X =5, Y= 1},
                new Point() {X =14, Y= 20},
                new Point() {X =3, Y= 4}
            };
            ClosestPairs cp = new ClosestPairs();
            double min = cp.ClosestPoints(pts, pts.Count());
            double actual = 1.4142135623730951;
            Assert.AreEqual(actual, min);
        }
    }
}
