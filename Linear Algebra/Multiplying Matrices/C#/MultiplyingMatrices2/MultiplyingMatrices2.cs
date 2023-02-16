/*
 * Programmer:      Corey Jenkins
 * Date:            August 31, 2022
 * Program Name:    MultiplyingMatrices.cs
 * Purpose:         A second demonstration on multiplying matrices using C#
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MultiplyingMatrices2
{
    class MultiplyingMatrices2
    {
        static void Main(string[] args)
        {
            /* These variables will give the product for the coordinates on the X, Y, and Z axis.
            [(2 -1 0), (3 2 -1), (-3, 1, 2)] and [(1,4,3)] Multiply then add. Dot Product.
            */
            int PointX, PointY, PointZ;
            PointX = (2 * 1) + (-1 * 4) + (0 * 3);
            PointY = (3 * 1) + (2 * 4) + (-1 * 3);
            PointZ = (-3 * 1) + (1 * 4) + (2 * 3);

            Console.WriteLine("The solution is " + "[" + PointX + "," + PointY + "," + PointZ + "].");
            Console.ReadKey();
        }
    }
}
