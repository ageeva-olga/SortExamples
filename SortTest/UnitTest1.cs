using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;

namespace SortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ar1 = new int[4] { 1, 2, 3, 4 };
            var ar2 = new int[3] { 5, 6, 7 };
            var ar3 = new int[1] { 8 };
            var result = QuickSort.Concatenate(ar1, ar2, ar3);
            for (int i = 0; i < 8; i++)
                Assert.AreEqual(result[i], i + 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var ar1 = new int[7] { 1, 0, 3, 4, 6, 5, 2 };
            var result = new QuickSort().Sort(ar1);
            for (int i = 0; i < 7; i++)
                Assert.AreEqual(result[i], i);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var ar1 = new int[7] { 1, 0, 3, 4, 6, 5, 2 };
            int baseElem = 4;
            var result = QuickSort.MoreThenBase(ar1, baseElem);
            Assert.AreEqual(result[0], 6);
            Assert.AreEqual(result[1], 5);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var ar1 = new int[7] { 1, 0, 3, 4, 6, 5, 2 };
            int baseElem = 4;
            var result = QuickSort.LessThenBase(ar1, baseElem);
            Assert.AreEqual(result[0], 1);
            Assert.AreEqual(result[1], 0);
            Assert.AreEqual(result[2], 3);
            Assert.AreEqual(result[3], 2);
        }
    }
}
