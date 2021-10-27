using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BranchingStructuresHomework
    {
        //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public static int GetCalc(int fNum, int sNum)
        {
            int result = 0;
            if (fNum > sNum)
            {
                result = fNum + sNum;
            }
            else if (fNum == sNum)
            {
                result = fNum * sNum;
            }
            else
            {
                result = fNum - sNum;
            }
            return result;
        }

        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка с координатами(X, Y).
        public static string DefineQuarter(int xCord, int yCord)
        {
            string res = "";

            if ((xCord > 0) && (yCord > 0)) 
            {
                res = "I четверть";
            }
            else if ((xCord < 0) && (yCord > 0)) 
            {
                res = "II четверть";
            }
            else if ((xCord < 0) && (yCord < 0)) 
            {
                res = "III четверть";
            }
            else if ((xCord > 0) && (yCord < 0)) 
            {
                res = "IV четверть";
            }
            else if((xCord == 0) && (yCord == 0))
            {
                res = "Начало координат";
            }
            else if ((xCord == 0))
            {
                res = "Точка лежит на оси Y";
            }
            else if ((yCord == 0))
            {
                res = "Точка лежит на оси Х";
            }
            return res;
        }

        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        public static int[] SortNumbers(int fNum, int sNum, int tNum)
        {
            int[] numbers = new int[] { fNum, sNum, tNum };

            ArraysHomework.SelectSort(numbers);
            return numbers; 
        }

        //Пользователь вводит 3 числа (A, B и С).
        //Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX^2+BX+C=0.
        public static double[] SolveSquareEquation(double  fNum, double sNum, double tNum)
        {
            if (sNum > 0)
            {
                double x1 = ((sNum * (-1)) + Math.Sqrt(sNum * sNum - 4 * fNum * tNum)) / 2 * fNum;
                double x2 = ((sNum * (-1)) - Math.Sqrt(sNum * sNum - 4 * fNum * tNum)) / 2 * fNum;
                double[] results = new double[] { x1, x2};
                return results;
            }
            else if (sNum == 0)
            {
                double x1 = ((sNum * (-1))) / 2 * fNum;
                double[] results = new double[] { x1 };
                return results;
            }
            else 
            {
                double[] results = new double[0];
                return results;
            }
        }

        //Пользователь вводит двузначное число.
        //Выведите в консоль прописную запись этого числа.
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string GetLiteral(int num)
        {
            string res;
            string res2 = "";

            switch (num - (num % 10))
            {
                case 10: res = "Десять"; break;
                case 11: res = "Одиннадцать"; break;
                case 12: res = "Двенадцать"; break;
                case 13: res = "Тринадцать"; break;
                case 14: res = "Четырнадцать"; break;
                case 15: res = "Пятнадцать"; break;
                case 16: res = "Шестнадцать"; break;
                case 17: res = "Семнадцать"; break;
                case 18: res = "Восемнадцать"; break;
                case 19: res = "Девятнадцать"; break;
                case 20: res = "Двадцать"; break;
                case 30: res = "Тридцать"; break;
                case 40: res = "Сорок"; break;
                case 50: res = "Пятьдесят"; break;
                case 60: res = "Шестьдесят"; break;
                case 70: res = "Семьдесят"; break;
                case 80: res = "Восемдесят"; break;
                case 90: res = "Девяносто"; break;

                default: res = "Не знаю такого :( "; break;
            }
            if (num % 10 != 0)
            {
                switch (num % 10)
                {
                    case 1: res2 = " один"; break;
                    case 2: res2 = " два"; break;
                    case 3: res2 = " три"; break;
                    case 4: res2 = " четыре"; break;
                    case 5: res2 = " пять"; break;
                    case 6: res2 = " шесть"; break;
                    case 7: res2 = " семь"; break;
                    case 8: res2 = " восемь"; break;
                    case 9: res2 = " девять"; break;
                }
            }
            return $"{res}{res2}";
        }

    }
}
