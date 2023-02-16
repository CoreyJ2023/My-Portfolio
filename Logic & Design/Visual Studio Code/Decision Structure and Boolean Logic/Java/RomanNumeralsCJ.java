/*
	Programmer: Corey Jenkins    
	Date: August 18, 2017 (Updated February 9, 2023)
	Filename: RomanNumeralsCJ.Java
	Description: To create a program that gives an error if a Roman Numeral is used outside I through X
 */

// We'll be needing the scanner to input numbers
import java.util.Scanner;

public class RomanNumeralsCJ {
	public static void main(String args[]) {
		// Let's make a module that will tells us whenever or not an error had occurred.
		showMessage();

	}

	public static void showMessage() {
		Scanner keyboard = new Scanner(System.in);

		// Enter a variable to put in a number for numbers
		int number;

		System.out.print("Please type in a number between 1 through 10: ");
		number = keyboard.nextInt();

		// Here, we will use the switch function.
		// The switch function is more organized then using the if, if else, and else
		// statements.
		// Each case is assigned by a constant. If you type in a number from 1 through
		// 10,
		// it will display the number assigned in each case.
		// If any other number, other than 1 through 10 is entered, then an error
		// should occur.
		switch (number) {
			case 1:
				System.out.println("Roman Numeral I");
				break;
			case 2:
				System.out.println("Roman Numeral II");
				break;
			case 3:
				System.out.println("Roman Numeral III");
				break;
			case 4:
				System.out.println("Roman Numeral IV");
				break;
			case 5:
				System.out.println("Roman Numeral V");
				break;
			case 6:
				System.out.println("Roman Numeral VI");
				break;
			case 7:
				System.out.println("Roman Numeral VII");
				break;
			case 8:
				System.out.println("Roman Numeral VIII");
				break;
			case 9:
				System.out.println("Roman Numeral VIIII");
				break;
			case 10:
				System.out.println("Roman Numeral X");
				break;
			default:
				System.out.println("An error has occurred. Please, use numbers 1 through 10.");
		}
	}
}
