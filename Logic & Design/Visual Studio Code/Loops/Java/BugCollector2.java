/*
 * Programmer:      Corey Jenkins
 * Date:            February 4, 2022
 * Filename:        BugCollector2.java
 * Purpose:         To create a program using a module, that runs a loop of seven days and putting in how many bugs you've collected a day.
 */

// Import the scanner for java.
import java.util.Scanner;

public class BugCollector2 {
    public static void main(String[] args) {
        showTotal();
    }

    public static void showTotal() {
        // Place the scanner for input.
        Scanner keyboard = new Scanner(System.in);

        // Integers bugs and days. Days will be used to loop.
        int bugs, days;

        // Another integer for total amount each day. It is set to 0
        int total = 0;

        for (days = 1; days < 7; days++) {
            System.out.println("Bug(s) collected:");
            bugs = keyboard.nextInt();

            // Formula.
            total = (total + bugs);

            System.out.println("Bug(s) collected for day " + days + ": " + bugs);
            System.out.println("Total amount: " + total);
        }
        // Sentence has been re-worked to be made sensical.
        System.out.println("The total amount collected in seven days: " + total + ".");

    }
}
