using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class CyclesHomework
    {
        //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
        public static int Exponentiation(int a, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= a;
            }

            return result;
        }

        //Пользователь вводит 1 число(A). Вывести все числа от 1 до 1000, которые делятся на A.
        public static void DisplaAllThatDevide(int num)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % num == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int FindCountOfLessSquare(int num)
        {
            int count = 0;
            for (int i = 0; i * i < num; i++) 
            {
                count++;
            }

            return count;
        }

        //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public static int GetGreatestDivisor(int num)
        {
            int res = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    res = i;
                }
            }
            return res;
        }

        //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B,
        //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        public static int PrintSumOfNumbers(int fNum, int sNum)
        {
            int result = 0;
            if (fNum > sNum)
            {
                VariablesHomework.Swap(ref fNum, ref sNum);
            }

            for (int i = fNum; i < sNum; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        ////Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1
        public static int GetFiboNumber(int num)
        {
            int fFib = 1;
            int sFib = 1;
            int res = 1;

            for (int i = 1; i < num - 1; i++)
            {
                res = fFib + sFib;
                int tmpFib = fFib;
                fFib = sFib;
                sFib = res;
            }
            return res;
        }

        //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        public static int GetGreatestCommonFactor(int fNum, int sNum)
        {
            while (fNum != sNum)
            {
                if (fNum > sNum)
                {
                    fNum = fNum - sNum;
                }
                else 
                {
                    sNum = sNum - fNum;
                }
            }
            return fNum;
        }

        //Пользователь вводит целое положительное число, которое является кубом целого числа N.
        //Найдите число N методом половинного деления.
        public static int FindСubeРalfDivision(int cube)
        {
            int rightBorder = cube;
            int leftBorder = 0;

            while (true)
            {
                int x = ((leftBorder + rightBorder) / 2);
                if (x * x * x == cube)
                {
                    return x;
                }
                else if (x * x * x < cube)
                {
                    leftBorder = x;
                }
                else
                {
                    rightBorder = x;
                }
            }
        }

        //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        public static int GetCountOfOddDigit(int num)
        {
            int a;
            int res = 0;

            while (true)
            {
                if (num == 0) 
                { 
                    break;
                }

                a = num % 10;
                num = num / 10;

                if (a % 2 != 0)
                {
                    res++;
                }
            }

            return res;
        }

        //Пользователь вводит 1 число.
        //Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
        //например, задано число 123, вывести 321.

        public static int FlipNumber(int num)
        {
            int res = 0;

            while (num != 0)
            {
                res *= 10;
                int tmp = num % 10;
                res += tmp;
                num = (num - tmp) / 10;
            }
            return num;
        }

        //Пользователь вводит целое положительное  число (a).
        //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        public static void PrintNumbersSumEvenDigitsGreater(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (Support.IsSumEvenDigitsGreater(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        public static bool IsSameNumbersHere(int fNum, int sNum)
        {
            bool result = false;
            int tmp = sNum;

            while (fNum != 0)
            {
                int a1 = fNum % 10;
                while (tmp != 0)
                {
                    if (tmp % 10 == a1)
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        tmp = tmp / 10;
                    }
                }
                fNum = (fNum - (fNum % 10)) / 10;
                tmp = sNum / 10;
            }
            return result;
        }
    }
}
