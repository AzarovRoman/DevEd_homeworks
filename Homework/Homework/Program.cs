using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Support.CreateArr(7);
            Support.Print1DArr(a);
            Console.WriteLine(ArraysHomework.GetSumElementWithOddIndex(a));
        }
    }
}
