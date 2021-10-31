using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Homework.Test
{
    class CyclesHomeworkTests
    {
        #region ExponentiationTests
        [TestCase(2, 4, 16)]
        [TestCase(10, 2, 100)]
        [TestCase(2, 0, 1)]
        [TestCase(1, 10, 1)]
        public void ExponentiationTest(int num, int exponent, int expected)
        {
            int actual = CyclesHomework.Exponentiation(num, exponent);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(123, -1)]
        public void ExponentiationTest_WhenExponentIsZero_ShouldThrowArgumentOutOfRangeException(int num, int exponent)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CyclesHomework.Exponentiation(num, exponent));
        }
        #endregion

        #region GetAllThatDevideTests
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(555, new int[] { 555 })]
        [TestCase(255, new int[] { 255, 510, 765 })]
        public void GetAllThatDevideTest(int num, int[] expected)
        {
            int[] actual = CyclesHomework.GetAllThatDevide(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetAllThatDevideTest_WhenArgumentIsLessThanOne_ShouldThrowsArgumentOutOfRangeException(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CyclesHomework.GetAllThatDevide(num));
        }
        #endregion

        #region CountOfLessSquareTests
        [TestCase(100, 10)]
        [TestCase(16, 4)]
        [TestCase(1, 1)]
        public void CountOfLessSquareTest(int num, int expected)
        {
            int actual = CyclesHomework.CountOfLessSquare(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void CountOfLessSquareTest_WhenArgumentIsLessThanOne_ShouldThrowsArgumentOutOfRangeException(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CyclesHomework.CountOfLessSquare(num));
        }
        #endregion

        #region GetGreatestDivisorTests
        [TestCase(18, 9)]
        [TestCase(2, 1)]
        [TestCase(10, 5)]
        public void GetGreatestDivisorTest(int num, int expected)
        {
            int actual = CyclesHomework.GetGreatestDivisor(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(1)]
        [TestCase(-12)]
        public void GetGreatestDivisorTest_WhenArgumentIsLessThanTwo_ShouldThrowsArgumentOutOfRangeException(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CyclesHomework.GetGreatestDivisor(num));
        }

        #endregion

        #region GetSumOfNumbersTests
        [TestCase(7, 14, 21)]
        [TestCase(8, 12, 0)]
        [TestCase(-7, 22, 35)]
        public void GetSumOfNumbersThatDivideSevenTest(int fNum, int sNum, int expected)
        {
            int actual = CyclesHomework.GetSumOfNumbersThatDivideSeven(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region GetFibonacciNumberTests
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(12, 144)]
        public void GetFibonacciNumberTest(int num, int expected)
        {
            int actual = CyclesHomework.GetFibonacciNumber(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetFibonacciNumberTest_WhenArgumentIsLessThanTwo_ShouldThrowsArgumentOutOfRangeException(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => CyclesHomework.GetFibonacciNumber(num));
        }
        #endregion

        #region GetGreatestCommonFactorTests
        [TestCase(18, 6, 6)]
        [TestCase(100, 1, 1)]
        [TestCase(71, 19, 1)]
        public void GetGreatestCommonFactorTest(int fNum, int sNum, int expected)
        {
            int actual = CyclesHomework.GetGreatestCommonFactor(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0, 1)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, -1)]
        [TestCase(-1, -1)]
        public void GetGreatestCommonFactorTest_WhenOneArgumentLessThanOne_ShouldThrowsArgumentOutOfRangeException(int fNum, int sNum)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=> CyclesHomework.GetGreatestCommonFactor(fNum, sNum));
        }
        #endregion

        #region FindСubeHalfDivisionTests
        [TestCase(125, 5)]
        [TestCase(0, 0)]
        [TestCase(-125, -5)]
        public void FindСubeHalfDivisionTest(int cube, int expected)
        {
            int actual = CyclesHomework.FindСubeHalfDivision(cube);

            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region GetCountOfOddDigitTests
        [TestCase(0, 0)]
        [TestCase(1111, 4)]
        [TestCase(12345, 3)]
        [TestCase(2468, 0)]
        [TestCase(-135, 3)]
        public void GetCountOfOddDigitTest(int num, int expected)
        {
            int actual = CyclesHomework.GetCountOfOddDigit(num);

            Assert.AreEqual(actual, expected);
        }
        #endregion

        #region FlipNumberTests
        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(-1234, -4321)]
        [TestCase(0, 0)]
        public void FlipNumberTest(int num, int expected)
        {
            int actual = CyclesHomework.FlipNumber(num);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region PrintNumbersSumEvenDigitsGreaterTests
        [TestCase(1, new int[] { })]
        [TestCase(15, new int[] { 2, 4, 6, 8, 12, 14})]
        public void PrintNumbersSumEvenDigitsGreaterTest(int num, int[] expected)
        {
            int[] actual = CyclesHomework.PrintNumbersSumEvenDigitsGreater(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void PrintNumbersSumEvenDigitsGreaterTest_WhenArgumentLessThanOne_ShouleThrowsArgumentOutOfRangeException(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=> CyclesHomework.PrintNumbersSumEvenDigitsGreater(num));
        }

        #endregion

        #region IsSameNumbersHereTests
        [TestCase(123, 1456, true)]
        [TestCase(-123, 1456, true)]
        [TestCase(123, 456, false)]
        [TestCase(-123, -1456, true)]
        [TestCase(0, 0, true)]
        public void IsSameNumbersHereTest(int fNum, int sNum, bool expected)
        {
            bool actual = CyclesHomework.IsSameNumbersHere(fNum, sNum);

            Assert.AreEqual(actual, expected);
        }



        #endregion
    }
}
