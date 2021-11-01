using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    class ArraysHomeworkTests
    {
        #region GetMinTests
        [TestCase(new int[] {0, 0, 0, 0, 0}, 0)]
        [TestCase(new int[] {-1, -10, -5, -22, -11}, -22)]
        [TestCase(new int[] {112, 123, 236, 1312, 41}, 41)]
        [TestCase(new int[] {-1, 5, 7, -12, 4}, -12)]
        public void GetMinTest(int[] array, int expected)
        {
            int actual = ArraysHomework.GetMin(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[0])]
        public void GetMinTest_WhenArraysLenghtIsZero_ShouldThrowsArgumentExeptions(int[] array)
        {
            Assert.Throws<ArgumentException>(()=>ArraysHomework.GetMin(array));
        }

        #endregion

        #region GetMaxTests
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { -1, -10, -5, -22, -11 }, -1)]
        [TestCase(new int[] { 112, 123, 236, 1312, 41 }, 1312)]
        [TestCase(new int[] { -1, 5, 7, -12, 4 }, 7)]
        public void GetMaxTest(int[] array, int expected)
        {
            int actual = ArraysHomework.GetMax(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[0])]
        public void GetMaxTest_WhenArraysLenghtIsZero_ShouldThrowsArgumentExeptions(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArraysHomework.GetMax(array));
        }

        #endregion

        #region GetIndexOfMinTests
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { -1, -10, -5, -22, -11 }, 3)]
        [TestCase(new int[] { 112, 123, 236, 1312, 41 }, 4)]
        [TestCase(new int[] { -1, 5, 7, -12, 4 }, 3)]
        public void GetIndexOfMinTest(int[] array, int expected)
        {
            int actual = ArraysHomework.GetIndexOfMin(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[0])]
        public void GetIndexOfMinTest_WhenArraysLenghtIsZero_ShouldThrowsArgumentExeptions(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArraysHomework.GetIndexOfMin(array));
        }

        #endregion

        #region GetIndexOfMaxTests
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { -1, -10, -5, -22, -11 }, 0)]
        [TestCase(new int[] { 112, 123, 236, 1312, 41 }, 3)]
        [TestCase(new int[] { -1, 5, 7, -12, 4 }, 2)]
        public void GetIndexOfMaxTest(int[] array, int expected)
        {
            int actual = ArraysHomework.GetIndexOfMax(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[0])]
        public void GetIndexOfMaxTest_WhenArraysLenghtIsZero_ShouldThrowsArgumentExeptions(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArraysHomework.GetIndexOfMax(array));
        }

        #endregion

        #region SummElementWithOddIndexTests
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { -1, -10, -5, -22, -11 }, -32)]
        [TestCase(new int[] { 112, 123, 236, 1312, 41, 12345}, 13780)]
        [TestCase(new int[] { -1, 5, 7, -12, 4 }, -7)]
        public void SummElementWithOddIndexTest(int[] array, int expected)
        {
            int actual = ArraysHomework.SummElementWithOddIndex(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[0])]
        public void GetMinSummElementWithOddIndexTest_WhenArraysLenghtIsZero_ShouldThrowsArgumentExeptions(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArraysHomework.SummElementWithOddIndex(array));
        }
        #endregion

        #region FlipArrayTest
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { -1, -10, -5, -22, -11 }, new int[] { -11, -22, -5, -10, -1 })]
        [TestCase(new int[] { 112, 123, 236, 1312, 41, 1 }, new int[] { 1, 41, 1312, 236, 123, 112})]
        public void FlipArrayTest(int[] array, int[] expected)
        {
            int[] actual = ArraysHomework.FlipArray(array);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[0])]
        public void FlipArrayTest_WhenArraysLenghtIsZero_ShouldThrowsArgumentExeptions(int[] array)
        {
            Assert.Throws<ArgumentException>(() => ArraysHomework.FlipArray(array));
        }
        #endregion


    }
}
