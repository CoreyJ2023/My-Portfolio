/*
 * Programmer:          Corey Jenkins
 * Date:                February 9, 2023
 * Filename:            RomanNumerals.cs
 * Purpose:             To create a program that gives an error if a Roman Numeral is used outside I through X
*/

using System;

namespace Roman_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral();
            Console.ReadKey();
        }

        static void RomanNumeral()
        {
            int numeral;

            Console.WriteLine("Enter a number between 1 and 10.");
            numeral = Convert.ToInt32(Console.ReadLine());

            switch (numeral)
            {
                case 1:
                    Console.WriteLine("I");
                    break;

                case 2:
                    Console.WriteLine("II");
                    break;

                case 3:
                    Console.WriteLine("III");
                    break;

                case 4:
                    Console.WriteLine("IV");
                    break;

                case 5:
                    Console.WriteLine("V");
                    break;

                case 6:
                    Console.WriteLine("VI");
                    break;

                case 7:
                    Console.WriteLine("VII");
                    break;

                case 8:
                    Console.WriteLine("VIII");
                    break;

                case 9:
                    Console.WriteLine("XI");
                    break;

                case 10:
                    Console.WriteLine("X");
                    break;

                default:
                    Console.WriteLine("An error has occurred.");
                    break;
            }
        }
    }
}
