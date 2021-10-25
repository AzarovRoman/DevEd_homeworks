using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class TwoDimensionalArraysHomework
    {
        //Найти минимальный элемент массива
        public static int SearchMin(int[,] array)
        {

            int min = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
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
        public static int SearchMax(int[,] array)
        {

            int max = array[0, 0];
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < max)
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        //Найти индекс минимального элемента массива
        public static int[] SearchIndexOfMin(int[,] array)
        {
            int min = array[0, 0];
            int[] indexesOfMin = new int[2];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
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
        public static int[] SearchIndexOfMan(int[,] array)
        {
            int min = array[0, 0];
            int[] indexesOfMin = new int[2];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > min)
                    {
                        min = array[i, j];
                        indexesOfMin[0] = i;
                        indexesOfMin[1] = j;
                    }
                }
            }

            return indexesOfMin;
        }

        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static int FindingBiggerNeighbor(int[,] array)
        {
            int count = 0;

            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < array.GetLength(1) - 1; j++)
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
