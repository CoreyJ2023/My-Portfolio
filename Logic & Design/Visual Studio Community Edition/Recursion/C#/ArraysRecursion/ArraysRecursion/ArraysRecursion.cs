using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysRecursion
{
    class ArraysRecursion
    {
        static void Main(string[] args)
        {
            const int SIZE = 9;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sum;

            sum = rangeSum(numbers, 2, 5);
            Console.WriteLine("The sum of the elements 2 through 5 is " + sum + ".");

            Console.ReadKey();

        }

        static int rangeSum(int[] arr, int start, int end)
        {
            if (start > end)
                return 0;
            else
                return arr[start] + rangeSum(arr, start + 1), end);
        }
    }
}
