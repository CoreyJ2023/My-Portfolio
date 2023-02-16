using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLoops
{
    class ArraysLoop
    {
        static void Main(string[] args)
        {
            const int SIZE = 3;
            int[] hours = new int[SIZE];

            int index;

            for(index = 0; index <= SIZE - 1; index++)
            {
                Console.Write("Please enter the amount of hours for employee #");
                Console.Write((index + 1) + ": ");
                hours[index] = Convert.ToInt32(Console.ReadLine());
            }

            for (index = 0; index <= SIZE - 1; index++)
            {
                Console.WriteLine("Here are the hours for employee #" + (index + 1) + ": " + hours[index]);
            }

            Console.ReadKey();
        }
    }
}
