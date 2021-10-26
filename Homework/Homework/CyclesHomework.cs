using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class CyclesHomework
    {
        //вспомогательная жуть!!!
        static bool IsSumEvenDigitsGreater(int num)
        {
            int even_sum = 0;
            int odd_sum = 0;
            bool result = false;
            if ((num % 10) % 2 == 0)
            {
                even_sum += num % 10;
                num = (num - (num % 10)) / 10;
            }
            else
            {
                odd_sum += num % 10;
                num = (num - (num % 10)) / 10;
            }
            if (even_sum > odd_sum)
            {
                result = true;
            }

            return result;
        }

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
        public static int[] DisplaAllThatDevide(int num)//В условии просят вывести, но мы вернем :)
        {
            int[] results = new int[1000/num];

            for (int i = 0; i <= 1000; i += num)
            {
                if (i % num == 0 && i != 0) 
                {
                    results[(i / num) - 1] = i;
                }
            }
            return results;
        }

        //Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int CountOfLessSquare(int num)
        {
            int count = 0;
            for (int i = 0; i * i < num; i++) 
            {
                count++;
            }

            return count;
        }

        //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public static int GetGreatestDivisor(int num)//УСКОРИТЬ В ДВА РАЗА!
        {
            int res = 0;
            for (int i = 1; i < num/2 + 1; i++)//возможно я дебил, но я отбросил половину нерабочих значений
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

            int x = 0;

            while (x * x * x != cube)
            {
                x = ((leftBorder + rightBorder) / 2);
                if (x * x * x < cube)
                {
                    leftBorder = x;
                }
                else
                {
                    rightBorder = x;
                }
            }
            return x;
        }

        //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        public static int GetCountOfOddDigit(int num)//НЕ ПОНЯЛ ЧТО ЗНАЧИТ "+1"
        {
            int a;
            int res = 0;

            while (num != 0)
            {
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
                num = num / 10;
            }
            return res;
        }

        //Пользователь вводит целое положительное  число (a).
        //Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        public static int[] PrintNumbersSumEvenDigitsGreater(int num)
        {
            int len = 0;
            for (int i = 0; i < num; i++)//в цикле узнаем длину массива
            {
                if (IsSumEvenDigitsGreater(i))
                {
                    len++;
                }
            }

            int[] results = new int[len];
            int currentIndex = 0; //индекс, под которым будем записывать подошедшее значение (ничего умнее пока не придумал :( )

            for (int i = 0; i < num; i++)
            {
                if (IsSumEvenDigitsGreater(i))
                {
                    results[currentIndex] = i;
                    currentIndex++;
                }
            }

            return results;
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
