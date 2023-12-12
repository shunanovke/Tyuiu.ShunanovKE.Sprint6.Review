using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint6.TaskReview.V17.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetRandMatrix()
        {
            DataService ds = new DataService();
            int n = 2, m = 3, n1 = -5, n2 = 6;
            int[,] res = ds.GetRandMatrix(n, m, n1, n2);
            int rows = res.GetUpperBound(0) + 1;
            int cols = res.Length / rows;
            Assert.AreEqual(n, rows);
            Assert.AreEqual(m, cols);
            Assert.AreEqual(res[0, 2], res[0,0] * res[0,1]);
        }
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] array = { { 1, 2, 3, 4, 4, 2, 7 },
                             { 3, 6, 1, 0, 3, 1, 1 },
                             { 1, 5, 2, 2, 4, 4, 2 }};
            int k = 3, l = 6;
            int r = 0;
            int res = ds.GetMatrix(array, k, l, r);
            int wait = 28;
            Assert.AreEqual(res, wait);
        }
    }
}
