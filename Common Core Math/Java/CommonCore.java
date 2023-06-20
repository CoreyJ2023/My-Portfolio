/*
* Programmer:       Corey Jenkins
* Date:             June 19, 2023
* Filename:         CommonCore.java
* Purpose:          A program that shows how to solve using the traditional way and through Common Core
 */

import java.util.Random;

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
         * I have tried using a while loop to see if it will keep looping random number
         * but it only loops up to three time and the looping breaks. So, we'll solve
         * this using the numbers of 7 and 2.
         * Take 12 and break it to 6 and 2 and 9 and break it into 3 and 3. take 6 and 3
         * from 12 and 9.
         */
        int step1 = 12;
        int step2 = step1 - 6;
        int solution = step2 - 3;
        System.out.println("The answer is " + solution + ".");
    }

}