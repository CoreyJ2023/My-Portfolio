using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmValidationInput1
{
    class AlgorithmValidationInput1
    {
        static void Main(string[] args)
        {
            int nonZeroNumber;

            Console.WriteLine("Enter a non-zero number: ");
            nonZeroNumber = Convert.ToInt32(Console.ReadLine());

            while (nonZeroNumber < 1)
            {
                Console.WriteLine("You've entered a non-zero number: " + nonZeroNumber + ".");
                Console.WriteLine("Enter a non-zero number: ");
                nonZeroNumber = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You have entered a non-zero number: " + nonZeroNumber);
            Console.ReadKey();
        }
    }
}
