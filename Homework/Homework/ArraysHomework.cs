using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class ArraysHomework
    {
        //Найти минимальный элемент массива
        public static int GetMinArraysElement(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        //Найти максимальный элемент массива
        public static int GetMaxArraysElement(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        //Найти индекс минимального элемента массива
        public static int GetIndexOfMinElement(int[] array)
        {
            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        //Найти индекс максимального элемента массива
        public static int GetIndexOfManElement(int[] array)
        {
            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        //Посчитать сумму элементов массива с нечетными индексами
        public static int GetSumElementWithOddIndex(int[] array)
        {
            int res = 0;
            int flag = 1;

            if (array.Length % 2 == 0)
            {
                flag = 0;
            }

            for (int i = 1; i < array.Length - flag; i += 2) //i был i+=2
            {
                res += array[i];
            }
            return res;
        }

        //Сделать реверс массива (массив в обратном направлении)
        public static int[] FlipArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            return array;
        }

        //Посчитать количество нечетных элементов массива
        public static int GetSumOddElement(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] % 2) == 1)
                {
                    count++;
                }
            }
            return count;
        }

        //Поменять местами первую и вторую половину массива,
        //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312
        public static int[] FlipHalfOfArry(int[] array)
        {
            for (int i = 0; i < (array.Length / 2); i++)
            {
                int tmpElem = array[i];
                array[i] = array[i + array.Length / 2 + (array.Length % 2)];
                array[i + array.Length / 2 + (array.Length % 2)] = tmpElem;
            }
            return array;
        }

        //Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
        //select:
        public static int[] SelectSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int indexOfMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }
                int tmpElem = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = tmpElem;
            }

            return array;
        }

        //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :
        //пузырьком(Bubble), выбором (Select) или вставками (Insert))
        //Bubble
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        int tmpElem = array[i];
                        array[i] = array[j];
                        array[j] = tmpElem;
                    }
                }
            }
            return array;
        }
    }
}
