/*
 * Programmer:          Corey Jenkins
 * Date:                August 17, 2023
 * Filename:            mathQuizFunction.cs
 * Purpose:             A math quiz program. This program will display two random numbers. A function is then made for the user to 
 *                      input the answer. An if/else statement is created and will return the answer if it is correct or incorrect.         
*/

using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementing the random feature.
            var randomNumber = new Random();
            int firstNumber, secondNumber, answer;

            // Generating a random number between 1 and 300 for the two integers.
            firstNumber = randomNumber.Next(1, 300);
            secondNumber = randomNumber.Next(1, 300);

            answer = quiz(firstNumber, secondNumber);
            Console.WriteLine(answer);

            Console.ReadKey();

        }

        static int quiz(int num1, int num2)
        {
            int result, inputAnswer;

            result = num1 + num2;
            Console.WriteLine(num1 + "+" + num2);
            Console.WriteLine("What's the answer? ");
            inputAnswer = Convert.ToInt32(Console.ReadLine());

            if(result == inputAnswer)
            {
                Console.WriteLine("This is correct!");
                return result;
            }
            else
            {
                Console.WriteLine("Incorrect!");
                return result;
            }
        }
    }
}
