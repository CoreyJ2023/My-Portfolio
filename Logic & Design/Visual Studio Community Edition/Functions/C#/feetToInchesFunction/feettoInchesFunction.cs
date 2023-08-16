/*
 * Programmer:      Corey Jenkins
 * Date:            August 15, 2023
 * Filename:        feetToInchesFunction.cs
 * Purpose:         To input feet and with a function to return it to inches.
 */

using System;

namespace feetToInchesFunction
{
    class feettoInchesFunction
    {
        static void Main(string[] args)
        {
            double feet, convertToInches;
            Console.WriteLine("Enter the amount of feet (distance): ");
            feet = Convert.ToDouble(Console.ReadLine());

            convertToInches = feetToInches(feet);
            Console.WriteLine(convertToInches);
            Console.ReadKey();
        }

        static double feetToInches(double num1)
        {
            double result;
            result = num1 / 12; // 1 ft = 12 inches. Divide.
            return result;
        }
    }
}
