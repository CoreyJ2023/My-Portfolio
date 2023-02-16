
/**Documentation
	Algorithm 1
	Programmer: Corey Jenkins
	Date: 11-11-2017
**/

import java.util.Scanner;

public class Algorithm1 {
	public static void main(String[] args) {
		Menu();
	}

	public static void Menu() {
		int menuSelection;
		Scanner keyboard = new Scanner(System.in);
		System.out.print("This is the main menu.");

		// The menu
		System.out.println("1. Open a menu");
		System.out.println("2. Close the currrent document");
		System.out.println("3. Print the current document.");
		System.out.println("4. Exit the program.");
		System.out.println();

		System.out.println("Enter your selection.");
		menuSelection = keyboard.nextInt();

		// Peform the selected operation
		if (menuSelection == 1)
			System.out.println("Opening the document.");
		else if (menuSelection == 2)
			System.out.println("Closing the current document.");
		else if (menuSelection == 3)
			System.out.println("Printing the current document.");
		else if (menuSelection == 4)
			System.out.println("Exiting the program.");
		else
			System.out.println("That is an invalid selection.");
	}
}
