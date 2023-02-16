
/**Documentation
	Algorithm 3
	Programmer: Corey Jenkins    Date: 11-12-2017
**/

import java.util.Scanner;

public class Algorithm3 {
	public static void main(String[] args) {
		Menu();
	}

	public static void Menu() {
		Scanner keyboard = new Scanner(System.in);
		int menuSelection;
		System.out.println("This is the main menu.");

		// The menu
		System.out.println("1. Open a menu");
		System.out.println("2. Close the current document");
		System.out.println("3. Print the current document.");
		System.out.println("4. Exit the program.");
		System.out.println();

		System.out.println("Enter your selection.");
		menuSelection = keyboard.nextInt();

		while (menuSelection < 1 || menuSelection > 4) {
			System.out.println("That is an invalid selection.");
			System.out.println("Enter 1, 2, 3, or 4: ");
			menuSelection = keyboard.nextInt();
		}

		// Peform the selected operation
		switch (menuSelection) {
			case 1:

				// Open the current document
				openDocument();
				break;

			case 2:
				// close the current document
				closeDocument();
				break;

			case 3:
				// Print the current document
				printDocument();
				break;

			case 4:
				// Exit the program
				System.out.println("Exiting Program.");
				break;
		}
	}

	public static void openDocument() {
		System.out.println("Opening the document");
	}

	public static void closeDocument() {
		System.out.println("Closing the document.");
	}

	public static void printDocument() {
		System.out.println("Printing the document.");
	}

}