using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Test
{
    class BranchingStructuresHomeworkTests
    {
        #region GetCalcTests
        [TestCase(-1, 11, -12)]
        [TestCase(10, 10, 100)]
        [TestCase(0, 0, 0)]
        [TestCase(1, -11, -10)]
        public void GetCalcTest(int fNum, int sNum, int expected)
        {
            int actual = BranchingStructuresHomework.GetCalc(fNum, sNum);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region DefineQuarterTests
        [TestCase(1, 1, "I четверть")]
        [TestCase(-1, 1, "II четверть")]
        [TestCase(1, -1, "IV четверть")]
        [TestCase(-1, -1, "III четверть")]
        [TestCase(0, 0, "Начало координат")]
        [TestCase(0, 1, "Точка лежит на оси Y")]
        [TestCase(1, 0, "Точка лежит на оси Х")]
        public void DefineQuarterTest(int xCord, int yCord, string expected)
        {
            string actual = BranchingStructuresHomework.DefineQuarter(xCord, yCord);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region SortNumbersTests
        [TestCase(3, 2, 1, new int[] { 1, 2, 3 })]
        [TestCase(-2, -3, -1, new int[] { -3, -2, -1 })]
        [TestCase(-2, 3, -1, new int[] { -2, -1, 3 })]
        [TestCase(1, 1, 1, new int[] { 1, 1, 1 })]
        public void SortNumbersTest(int fNum, int sNum, int tNum, int[] expected)
        {
            int[] actual = BranchingStructuresHomework.SortNumbers(fNum, sNum, tNum);

            Assert.AreEqual(actual, expected);
        }

        #endregion

        #region SolveSquareEquationTests
        [TestCase(5, 10, 5, new double[] { -1d })]
        [TestCase(1, 10, 0, new double[] { 0d, -10d })]
        [TestCase(-5, -10, -5, new double[] { -1d })]
        [TestCase(10, 20, 30, new double[] { })]
        public void SolveSquareEquationTest(double fNum, double sNum, double tNum, double[] expected)
        {
            double[] actual = BranchingStructuresHomework.SolveSquareEquation(fNum, sNum, tNum);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 2)]
        public void SolveSquareEquationTest_WhenFirstArgumentIsZero_ShouldThrowsDivideByZeroException(double fNum, double sNum, double tNum)
        {
            Assert.Throws<DivideByZeroException>(()=>BranchingStructuresHomework.SolveSquareEquation(fNum, sNum, tNum));
        }
        #endregion

        #region GetLiteralTests
        [TestCase(25, "Двадцать пять")]
        [TestCase(47, "Сорок семь")]
        [TestCase(90, "Девяносто")]
        [TestCase(10, "Десять")]
        [TestCase(15, "Пятнадцать")]
        [TestCase(19, "Девятнадцать")]
        [TestCase(99, "Девяносто девять")]
        public void GetLiteralTest(int num, string expected)
        {
            string actual = BranchingStructuresHomework.GetLiteral(num);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(9)]
        [TestCase(100)]
        public void GetLiteralTest_WhenArgumentGreaterThan100OrLessThan10_ShouldThrowsArgumentOutOfRangeException(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>BranchingStructuresHomework.GetLiteral(num));
        }
        #endregion
    }
}
