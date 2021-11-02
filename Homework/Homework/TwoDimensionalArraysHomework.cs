using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class TwoDimensionalArraysHomework
    {
        //Найти минимальный элемент массива
        public static int GetMin(int[,] array)
        {
            if(array.GetLength(1) == 0 || array.GetLength(0) == 0)
            {
                throw new ArgumentException();
            }

            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }

            return min;
        }

        //Найти максимальный элемент массива
        public static int GetMax(int[,] array)
        {
            if (array.GetLength(1) == 0 || array.GetLength(0) == 0)
            {
                throw new ArgumentException();
            }

            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        //Найти индекс минимального элемента массива
        public static int[] GetIndexOfMin(int[,] array)
        {
            if (array.GetLength(1) == 0 || array.GetLength(0) == 0)
            {
                throw new ArgumentException();
            }

            int min = array[0, 0];
            int[] indexesOfMin = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        indexesOfMin[0] = i;
                        indexesOfMin[1] = j;
                    }
                }
            }

            return indexesOfMin;
        }

        //Найти индекс максимального элемента массива
        public static int[] GetIndexOfMax(int[,] array)
        {
            if (array.GetLength(1) == 0 || array.GetLength(0) == 0)
            {
                throw new ArgumentException();
            }

            int max = array[0, 0];
            int[] indexesOfMax = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indexesOfMax[0] = i;
                        indexesOfMax[1] = j;
                    }
                }
            }

            return indexesOfMax;
        }

        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static int CountBiggerNeighbor(int[,] array)
        {
            if (array.GetLength(1) == 0 || array.GetLength(0) == 0)
            {
                throw new ArgumentException();
            }

            int count = 0;

            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {

                    if ((i==0 || array[i,j]>array[i-1,j]) 
                        && (j == 0 || array[i, j] > array[i, j-1])
                        && (i==array.GetLength(0)-1 || array[i,j]>array[i+1,j])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j+1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //Отразите массив относительно его главной диагонали
        public static int[,] FlipMatrix(int[,] array)
        {
            if (array.GetLength(1) == 0 || array.GetLength(0) == 0 || array.GetLength(1) != array.GetLength(0))
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    int tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }

            return array;
        }
    }
}
