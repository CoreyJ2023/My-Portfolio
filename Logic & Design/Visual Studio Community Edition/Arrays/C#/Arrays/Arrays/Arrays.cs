/*
 * Programmer:      Corey Jenkins
 * Date:            April 19, 2021
 * Program Name     Arrays.cs
 * Purpose:         A Demonstration on using Arrays in C#
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            const int SIZE = 3;
            int[] hours = new int[SIZE];

            Console.WriteLine("Enter hours for employee #1: ");
            hours[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hours for employee #2: ");
            hours[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hours for employee #3: ");
            hours[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("These are the hours for employees #1, #2, and #3: ");
            Console.WriteLine(hours[0]);
            Console.WriteLine(hours[1]);
            Console.WriteLine(hours[2]);

            Console.ReadKey();
        }
    }
}
