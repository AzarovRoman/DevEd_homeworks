using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class VariablesHomework
    {
        //Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5A+B^2)/B-A
        public static double GetCalc(int fNum, int sNum)//изменил тип данных!
        {
            int result = (5 * fNum + sNum * sNum) / sNum - fNum;
            return result;
        }

        //Пользователь вводит 2 строковых значения(A и B). Поменяйте содержимое переменных A и B местами.
        public static void Swap<T>(ref T fStr, ref T sStr)
        {
            T tmp = fStr;
            fStr = sStr;
            sStr = tmp;
        }

        //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B.
        public static int Division(int fNum, int sNum)
        {
            return fNum / sNum;
        }

        //Пользователь вводит 2 числа (A и B). Выведите в консоль остаток от деления A на B.
        public static int GetRemainder(int fNum, int sNum)
        {
            return fNum % sNum;
        }

        //Пользователь вводит 3 не равных 0 числа (A, B и С).
        //Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public static double GetEquationValue(int fNum, int sNum, int tNum)
        {
            double result = (tNum - sNum) / fNum;
            return result;
        }

        //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
        //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
        public static string PrintEquation(double x1, double y1, double x2, double y2)
        {
            string result = "";

            if (x1 == 0 || x2 == 0 || y1 == 0 || y2 == 0)
            {
                result = "Не умею работать с нулями";
            }
            else
            {
                double fParameter = (y1 - y2) / (x1 - x2);
                double sParameter = y2 - fParameter * x2;

                result = $"Y =  + {fParameter} + X +  + {sParameter}";
            }
            return result;
        }
    }
}
