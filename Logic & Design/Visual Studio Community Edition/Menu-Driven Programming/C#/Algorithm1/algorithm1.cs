/*
 * Programmer:          Corey Jenkins
 * Date:                February 11, 2023
 * Filename:            algorithm1.cs
 * Purpose:            A demonstration of an event-driven program using a if/else statement. 
*/

using System;

namespace Algorithm1
{
    class algorithm1
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }

        static void menu()
        {
            int menuSelection;
            Console.WriteLine("This is the main menu.");
            Console.WriteLine("1. Open the menu.");
            Console.WriteLine("2. Close the current document.");
            Console.WriteLine("3. Print the current document.");
            Console.WriteLine("4. Exit the program.");

            Console.WriteLine("Enter your selection:");
            menuSelection = Convert.ToInt32(Console.ReadLine());

           if(menuSelection == 1)
            {
                Console.WriteLine("Opening the document.");
            }
           else if(menuSelection == 2)
            {
                Console.WriteLine("Closing the document.");
            }
           else if(menuSelection == 3)
            {
                Console.WriteLine("Printing the document.");
            }
           else if(menuSelection == 4)
            {
                Console.WriteLine("Exiting the program.");
            }
           else
            {
                Console.WriteLine("An error has occurred.");
            }
        }
    }
}
