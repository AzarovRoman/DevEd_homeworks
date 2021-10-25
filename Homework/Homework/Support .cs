using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Support
    {
        public static int[] CreateArr(int len= 10)
        {
            Random random = new Random();

            int[] numbers = new int[len];

            for (int i = 0; i < numbers.Length; i++)
            {
                int tmpNumb = random.Next(-100, 101);
                numbers[i] = tmpNumb;
            }
            return numbers;
        }

        public static void Print1DArr(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]} ");
            }
            Console.WriteLine();
        }

        public static bool IsSumEvenDigitsGreater(int num)
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
                result =  true;
            }

            return result;
        }

        public static void Print2DArr(int[,] numbers) //Печать массива в консоль
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] Create2DArr(int row = 5, int col = 5) //метод создания двумерного массива
        {
            int[,] numbers = new int[row, col];

            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(-100, 101);
                }
            }

            return numbers;
        }
    }
}
