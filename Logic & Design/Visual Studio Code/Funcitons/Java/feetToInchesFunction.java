
/*
 * Programmer:      Corey Jenkins
 * Date:            August 15, 2023
 * Filename:        feetToInchesFunction.java
 * Purpose:         To input feet and with a function to return it to inches.
 */
import java.util.Scanner;

public class feetToInchesFunction {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int feet, inchesReturn;
        System.out.println("Enter a number(s): ");
        feet = input.nextInt();

        inchesReturn = sizeFeet(feet);
        System.out.println("Feet to inches:" + inchesReturn + ".");
    }

    public static int sizeFeet(int num1) {
        int inches, result;
        inches = 12;
        result = num1 / inches;

        return result;
    }
}
