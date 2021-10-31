using NUnit.Framework;
using System;

namespace Homework.Test
{
    public class VariablesHomeworkTests
    {
        #region GetCalcTest
        [TestCase(10.0, 20.0, 45.0)]
        [TestCase(-10.0, 20.0, 11.6)]
        [TestCase(-1.0, -2.0, 1)]
        [TestCase(0.0, 12.0, 12.0)]

        public void GetCalcTest(double fNum, double sNum, double expected)
        {
            double actual = VariablesHomework.GetCalc(fNum, sNum);

            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestCase(0, 0)]
        [TestCase(590, 590)]
        [TestCase(-100, -100)]
        public void GetCalcTest_WhenWhenArgumentsAreEqual_ShouldThrowsArgumentExeption(double fNum, double sNum)
        {
            Assert.Throws<ArgumentException>(() => VariablesHomework.GetCalc(fNum, sNum));
        }
        #endregion

        #region DivisionTest
        [TestCase(10, 20, 0)]
        [TestCase(-8, 4, -2)]
        [TestCase(-100, -15, 6)]
        [TestCase(15, -7, -2)]
        [TestCase(1234, 1, 1234)]
        public void DivisionTest(int fNum, int sNum, int expected)
        {
            int actual = VariablesHomework.Division(fNum, sNum);

            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region GetRemainderTest
        [TestCase(10, 3, 1)]
        [TestCase(-7, -4, -3)]
        [TestCase(-21, 5, -1)]
        [TestCase(22, -6, 4)]
        public void GetRemainderTest(int fNum, int sNum, int expected)
        {
            int actual = VariablesHomework.GetRemainder(fNum, sNum);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 0)]
        public void GetRemainderTest_WhenSecondArgumetnIsZero_ShouldThrowsDivideByZeroException(int fNum, int sNum)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHomework.GetRemainder(fNum, sNum));
        }
        #endregion

        #region GetEquationValue
        [TestCase(10, 20, 30, 1)]
        [TestCase(-10, 20, 30, -1)]
        [TestCase(-10, -20, -30, 1)]
        [TestCase(10, 20, 30, 1)]
        [TestCase(10, 20, 30, 1)]
        public void GetEquationValueTest(double fNum, double sNum, double tNum, double expected)
        {
            double actual = VariablesHomework.GetEquationValue(fNum, sNum, tNum);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, 5d, 12d)]
        public void GetEquationValueTest_WhenFirstArgumetnIsZero_ShouldThrowsDivideByZeroException(double fNum, double sNum, double tNum)
        {
            Assert.Throws<DivideByZeroException>(()=>VariablesHomework.GetEquationValue(fNum, sNum, tNum));
        }

        #endregion

        #region PrintEquationTest
        [TestCase(1d, 2d, 3d, 4d, "Y = 1X + 1")]
        [TestCase(-1d, -2d, -3d, -4d, "Y = 1X -1")]
        [TestCase(2d, 3d, -3d, 6d, "Y = -0,6X + 4,2")]
        public void PrintEquationTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actual = VariablesHomework.PrintEquation(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, 1d, 2d, 3d)]
        [TestCase(1d, 0d, 2d, 3d)]
        [TestCase(2d, 1d, 0d, 3d)]
        [TestCase(3d, 1d, 2d, 0d)]
        public void PrintEquationTest_WhenAnyArgumentIsZero_ShouldThrowsArgumentException(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<ArgumentException>(()=>VariablesHomework.PrintEquation(x1, y1, x2, y2));
        }

        [TestCase(14d, 2d, 14d, 3d)]
        [TestCase(-14d, 2d, -14d, 3d)]
        public void PrintEquationTest_WhenX1IsEqualToX2_ShouldThrowsDivideByZeroException(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<DivideByZeroException>(() => VariablesHomework.PrintEquation(x1, y1, x2, y2));
        }

        #endregion
    }
}