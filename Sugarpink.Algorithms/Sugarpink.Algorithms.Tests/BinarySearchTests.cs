using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Sugarpink.Algorithms.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        BinarySearch Sut { get; } = new BinarySearch();

        [Timeout(1000)]
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(2, 1)]
        [DataRow(4, 2)]
        [DataRow(6, 3)]
        [DataRow(8, 4)]
        [DataRow(10, 5)]
        [DataRow(12, 6)]
        [DataRow(14, 7)]
        [DataRow(16, 8)]
        [DataRow(18, 9)]
        [DataRow(20, 10)]
        [DataRow(1, -1)]
        [DataRow(3, -1)]
        [DataRow(5, -1)]
        [DataRow(7, -1)]
        [DataRow(9, -1)]
        [DataRow(11, -1)]
        [DataRow(13, -1)]
        [DataRow(15, -1)]
        [DataRow(17, -1)]
        [DataRow(19, -1)]
        [DataRow(21, -1)]
        public void SearchInListWithUnevenElements(int value, int expectedIndex)
        {
            var list = new List<int> { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            var actualIndex = Sut.Search(value, list);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Timeout(1000)]
        [DataTestMethod]
        [DataRow(1, 0)]
        [DataRow(3, 1)]
        [DataRow(5, 2)]
        [DataRow(7, 3)]
        [DataRow(9, 4)]
        [DataRow(11, 5)]
        [DataRow(13, 6)]
        [DataRow(15, 7)]
        [DataRow(17, 8)]
        [DataRow(19, 9)]
        [DataRow(2, -1)]
        [DataRow(4, -1)]
        [DataRow(6, -1)]
        [DataRow(8, -1)]
        [DataRow(10, -1)]
        [DataRow(12, -1)]
        [DataRow(14, -1)]
        [DataRow(16, -1)]
        [DataRow(18, -1)]
        [DataRow(20, -1)]
        public void SearchInListWithEvenElements(int value, int expectedIndex)
        {
            var list = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            var actualIndex = Sut.Search(value, list);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

    }
}
