/*
 * Programmer:      Corey Jenkins
 * Date:            February 11, 2023
 * Filename:        Algorithm2.cs
 * Purpose:         A demonstration of an menu-driven program in C# using a While Loop for input validation and a Switch to select.
*/

using System;

namespace Algorithm2
{
    class algorithm2
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();

        }
        static void menu()
        {    int menuSelection;
             Console.WriteLine("This is the main menu.");
             Console.WriteLine("1. Open the menu.");
             Console.WriteLine("2. Close the current document.");
             Console.WriteLine("3. Print the current document.");
             Console.WriteLine("4. Exit the program.");

             Console.WriteLine("Enter your selection:");
             menuSelection = Convert.ToInt32(Console.ReadLine());

             while(menuSelection < 1 || menuSelection > 4)
             {
                Console.WriteLine("An error has occurred.");
                Console.WriteLine("Enter your selection (1 to 4):");
                menuSelection = Convert.ToInt32(Console.ReadLine());
             }

             switch(menuSelection)
             {
                case 01:
                    Console.WriteLine("Opening the menu.");
                break;


                case 02:
                    Console.WriteLine("Closing the document.");
                break;

                case 03:
                    Console.WriteLine("Print the document.");
                break;

                case 04:
                   Console.WriteLine("Exiting the program.");
                break;
             }
        }
    }
}
