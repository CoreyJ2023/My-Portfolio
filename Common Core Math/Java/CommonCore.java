/*
* Programmer:       Corey Jenkins
* Date:             June 19, 2023 (Updated July 6, 2023)
* Filename:         CommonCore.java
* Purpose:          A program that shows how to solve using the traditional way and through Common Core
 */

public class CommonCore {
    public static void main(String[] args) {
        // Declare variables to calculate the problem tradtionally
        int Number1 = 12;
        int Number2 = 9;
        int SimpleAnswer = Number1 - Number2;
        System.out.println(
                "Sophie jumped on one foot 12 times in a row. Tyler jumped on one foot 9 times. How many more jumps did Sophie jump?");
        System.out.println("The answer is: " + SimpleAnswer + "... But that's too easy. Let's try Common Core");

        CommonCoreMode();
    }

    public static void CommonCoreMode() {
        /*
         * Take 9 and break it to 7 and 2.
         */

        showNumbers(7, 2);
    }

    public static void showNumbers(int num1, int num2) {
        int number = 12;
        int part1 = number - num1;
        int commonCoreAnswer = part1 - num2;
        System.out.println("The Common Core answer is " + commonCoreAnswer + ".");

    }

}