/*
 * Programmer:      Corey Jenkins
 * Date:            August 15, 2023
 * Filename:        mathQuizFunction.java
 * Purpose:         A math quiz program. This program will display two random numbers. A function is then made for the user to 
 *                  input the answer. An if/else statement is created and will return the answer if it is correct or incorrect.
 */

import java.util.Scanner;
import java.util.Random;

public class mathQuizFunction {
    public static void main(String[] args) {
        Random randomMathNumbers = new Random();

        int firstNumber, secondNumber, answer;

        firstNumber = randomMathNumbers.nextInt(300) + 1;
        secondNumber = randomMathNumbers.nextInt(300) + 1;
        answer = quiz(firstNumber, secondNumber);
        System.out.println(answer);
    }

    public static int quiz(int num1, int num2) {
        Scanner input = new Scanner(System.in);
        int result, inputAnswer;
        System.out.println(num1 + "+" + num2);
        System.out.println("Enter your answer:");
        inputAnswer = input.nextInt();

        result = num1 + num2;

        if (inputAnswer == result) {
            System.out.println("This is correct.");
            return result;
        } else {
            System.out.println("Incorrect.");
            return result;
        }
    }
}
