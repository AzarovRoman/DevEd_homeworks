using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    public class TwoDimensionalArraysHomeworkTests
    {
        #region GetMinTests
        [TestCase("positive", 3)]
        [TestCase("negative", -99)]
        [TestCase("zero", 0)]
        [TestCase("moreCols", -99)]
        [TestCase("moreRows", -999)]
        [TestCase("1", -99)]
        public void GethMinTest(string type, int expected)
        {
            int actual = TwoDimensionalArraysHomework.GetMin(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void GethMinTest_WhenLenghtRowOrColIsZero_ShouldThrowsArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArraysHomework.GetMin(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

        #region GetMaxTests
        [TestCase("positive", 99)]
        [TestCase("negative", -3)]
        [TestCase("zero", 0)]
        [TestCase("moreCols", 23)]
        [TestCase("moreRows", 113)]
        [TestCase("1", 11)]
        public void GetMaxTest(string type, int expected)
        {
            int actual = TwoDimensionalArraysHomework.GetMax(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void GetMaxTest_WhenLenghtRowOrColIsZero_ShouldThrowsArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArraysHomework.GetMax(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

        #region GetIndexOfMinTests
        [TestCase("positive", new int[] { 0, 1 })]
        [TestCase("negative", new int[] { 1, 1 })]
        [TestCase("zero", new int[] { 0, 0 })]
        [TestCase("moreCols", new int[] { 1, 1 })]
        [TestCase("moreRows", new int[] { 3, 2 })]
        [TestCase("1", new int[] { 1, 1 })]
        public void GetIndexOfMinTest(string type, int[] expected)
        {
            int[] actual = TwoDimensionalArraysHomework.GetIndexOfMin(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void GetIndexOfMinTest_WhenLenghtRowOrColIsZero_ShouldThrowsArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArraysHomework.GetIndexOfMin(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

        #region GetIndexOfMaxTests
        [TestCase("positive", new int[] { 1, 1 })]
        [TestCase("negative", new int[] { 0, 1 })]
        [TestCase("zero", new int[] { 0, 0 })]
        [TestCase("moreCols", new int[] { 2, 2 })]
        [TestCase("moreRows", new int[] { 3, 1 })]
        [TestCase("1", new int[] { 2, 0 })]
        public void GetIndexOfMaxTest(string type, int[] expected)
        {
            int[] actual = TwoDimensionalArraysHomework.GetIndexOfMax(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void GetIndexOfMaxTest_WhenLenghtRowOrColIsZero_ShouldThrowsArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArraysHomework.GetIndexOfMax(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

        #region CountBiggerNeighborTest
        [TestCase("positive", 1)]
        [TestCase("negative", 1)]
        [TestCase("zero", 0)]
        [TestCase("moreCols", 1)]
        [TestCase("moreRows", 2)]
        [TestCase("1", 1)]
        public void CountBiggerNeighborTest(string type, int expected)
        {
            int actual = TwoDimensionalArraysHomework.CountBiggerNeighbor(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        public void CountBiggerNeighborTest_WhenLenghtRowOrColIsZero_ShouldThrowsArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArraysHomework.CountBiggerNeighbor(GetTwoDimensionalArrayMock(type)));
        }
        #endregion

        #region FlipMatrixTests
        [TestCase("positive", "positive")]
        [TestCase("negative", "negative")]
        [TestCase("zero", "zero")]
        [TestCase("1", "1")]
        public void FlipMatrixTest(string type, string expectedType)
        {
            int[,] expected = GetFlipMatrixMock(expectedType);
            int[,] actual = TwoDimensionalArraysHomework.FlipMatrix(GetTwoDimensionalArrayMock(type));

            Assert.AreEqual(expected, actual);
        }

        [TestCase("lenghtLess")]
        [TestCase("moreCols")]
        [TestCase("moreRows")]
        public void FlipMatrixTest_WhenLenghtRowOrColIsZero_ShouldThrowsArgumentException(string type)
        {
            Assert.Throws<ArgumentException>(() => TwoDimensionalArraysHomework.FlipMatrix(GetTwoDimensionalArrayMock(type)));
        }

        #endregion

        #region Mocks
        public static int[,] GetTwoDimensionalArrayMock(string arrayType)
        {
            switch (arrayType)
            {
                case "positive":
                    return new int[,] { {5, 3, 6 }, {12, 99, 8 }, {11, 18, 23 } };
                case "negative":
                    return new int[,] { { -5, -3, -6 }, { -12, -99, -8 }, { -11, -18, -23 } };
                case "zero":
                    return new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                case "moreCols":
                    return new int[,] { { 5, -3, 6, 7}, { -12, -99, 0, 13 }, { 11, 0, 23, -9 } };
                case "moreRows":
                    return new int[,] { { 5, -3, 6 }, { -12, -99, 0 }, { 11, 0, -23 }, { 7, 113, -999 } };
                case "lenghtLess":
                    return new int[,] { };
                default: //mixed
                    return new int[,] { { 5, -3, 6 }, { -12, -99, 0 }, { 11, 0, -23 } };
            }
        }

        public static int[,] GetFlipMatrixMock(string arrayType)
        {
            switch (arrayType)
            {
                case "positive":
                    return new int[,] { { 5, 12, 11 }, { 3, 99, 18 }, { 6, 8, 23 } };
                case "negative":
                    return new int[,] { { -5, -12, -11 }, { -3, -99, -18 }, { -6, -8, -23 } };
                case "zero":
                    return new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                case "moreCols":
                    return new int[,] { { 5, -3, 6, 7 }, { -12, -99, 0, 13 }, { 11, 0, 23, -9 } };
                case "moreRows":
                    return new int[,] { { 5, -3, 6 }, { -12, -99, 0 }, { 11, 0, -23 }, { 7, 113, -999 } };
                case "lenghtLess":
                    return new int[,] { };
                default: //mixed
                    return new int[,] { { 5, -12, 11 }, { -3, -99, 0 }, { 6, 0, -23 } };
            }
        }
        #endregion
    }
}
