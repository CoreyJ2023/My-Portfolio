/*
 * Programmer:      Corey Jenkins
 * Program Name:    SequentialSearch.cs
 * Program Date:    November 5, 2021
 * Purpose:         A demonstration on using arrary with a boolean, while-loop and if/else statements.
*/

using System;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 87, 75, 98, 100, 82, 72, 88, 92, 60, 78 };

            Boolean found;

            // Declare a varaible to use as a loop counter.
            int index;

            found = false;

            index = 0;

            while (found == false && index < scores.Length)
            {
                if (scores[index] == 100)
                    found = true;
                else
                    index = index + 1;
            }

            // Display the search results
            if (found)
                Console.WriteLine("You earned 100 on test number " + (index + 1) + ".");

            else
                Console.WriteLine("You did not earn 100 on any test.");
            
        }
    }
}
