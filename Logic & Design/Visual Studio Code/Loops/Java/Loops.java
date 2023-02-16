/*
 * Programmer:      Corey Jenkins  
 * Filename:        Loops.java
 * Date:            October 17, 2022
 * Purpose:         Pass down two numbers and then place a number in a loop.
 */

public class Loops {

    public static void main(String[] args) {
        int firstNumber = 3;
        int secondNumber = 5;
        showNum(firstNumber, secondNumber);
    }

    public static void showNum(int num1, int num2) {
        int answer;
        answer = (num1 + num2);
        int index;

        for (index = 0; index < answer; index++) {
            System.out.println("Hello World!");
        }
    }
}