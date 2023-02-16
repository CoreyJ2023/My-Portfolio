/*
 * Programmer:      Corey Jenkins
 * Program Name:    RecursiveFactoral.cs
 * Date:            Octoer 13, 2021
 * Purpose:         A demonstration of making a factorial using a recursive. A While loop is placed as an input valdiation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveFactorial
{
    class RecursiveFactorial
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a non-negative number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number < 0)
            {
                Console.WriteLine("You have entered a non-negative number.");
                Console.WriteLine("Enter a non-negative number.");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The factorial of " + number + " is " + factorial(number) + ".");
            Console.ReadKey();
        }

        static int factorial(int n) // Pass by argument
        {
            if (n == 0)
                return 1;
            else
                return n * factorial(n - 1);
        }

    }
}
