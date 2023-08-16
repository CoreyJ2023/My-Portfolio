

using System;
/*
 * Programmer:      Corey Jenkins
 * Date:            August 15, 2023
 * Filename:        areaRectangleFunction.cs
 * Purpose:         A program in which returns the area of a rectangle.
*/
namespace areaRectangleFunction
{
    class areaRectangleFunction
    {
        static void Main(string[] args)
        {
            int rectangleLength, rectangleWidth, areaFunction;
            Console.WriteLine("Enter the length: ");
            rectangleLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            rectangleWidth = Convert.ToInt32(Console.ReadLine());

            areaFunction = area(rectangleLength, rectangleWidth);
            Console.WriteLine(areaFunction);
            Console.ReadKey(); // Pause the program.
        }

        static int area(int num1, int num2)
        {
            int result;
            result = num1 * num2;
            return result;
        }
    }
}
