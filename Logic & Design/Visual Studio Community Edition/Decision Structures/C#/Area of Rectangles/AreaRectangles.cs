/*
 * Programmer:      Corey Jenkins
 * Date:            February 9, 2023
 * Filename:        AreaRectangles.cs
 * Purpose:         To create a program that inputs the area of two rectangles
	                and determine if both are the same or not.
*/

using System;

namespace Area_of_Rectangles
{
    class AreaRectangles
    {
        static void Main(string[] args)
        {
            // Function 
            RectangleArea();
            Console.ReadKey();
        }

        static void RectangleArea()
        {
            // Integers for length and width for two rectangles.
            int length1, width1;
            int length2, width2;
            int rectangle1, rectangle2;

            Console.WriteLine("Enter the length for the first rectangle: ");
            length1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width for the first rectangle: ");
            width1 = Convert.ToInt32(Console.ReadLine());

            // Area of Rectangle 1
            rectangle1 = (length1 * width1);

            // Rectangle 2
            Console.WriteLine("Enter the length of the second rectangle: ");
            length2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the second rectangle: ");
            width2 = Convert.ToInt32(Console.ReadLine());

            // Area of Rectangle 2
            rectangle2 = (length2 * width2);

            TwoRectangles(rectangle1, rectangle2);
        }

        static void TwoRectangles(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Yes! The dimensions are the same.");
            }
            else
            {
                Console.WriteLine("No! The dimensions are not the same.");
            }
        }
    }
}
