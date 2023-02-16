/**Documentation
	Chapter 11
	Programming Excercise 01: Language Translator
	Programmer: Corey Jenkins    Date: 11-11-2017
	Purpose: To create a menu driven program that choses one of four langauges
**/


import java.util.Scanner;

public class languagesCJ
{
	public static void main(String[] args)
	{
		showMessage();
	}

	public static void showMessage()
	{
		// Declare a variable to hold the
		// user's menu selection.
		int menuSelection;

		// Create a Scanner object for keyboard input.
		Scanner keyboard = new Scanner(System.in);

		// Display the menu.
		System.out.println("Select a language.");
		System.out.println("1. English");
		System.out.println("2. Italian");
		System.out.println("3. Spanish");
		System.out.println("4. German");
		System.out.println("5. End the program!");
		System.out.println();

		// Prompt the user for a selection
		System.out.print("Enter your selection: ");
		menuSelection = keyboard.nextInt();

		// Validate the menu selection.
		while (menuSelection < 1 || menuSelection > 5)
		{
			System.out.println("That is an invalid selection.");
			System.out.print("Enter 1, 2, 3, 4, or 5: ");
			menuSelection = keyboard.nextInt();
		}

		// Perform the selected operation
		switch(menuSelection)
		{
			case 1:
			// English/Inglés/Englisch
			System.out.println("Good morning.");
			break;

			case 2:
			// Italian
			System.out.println("Buongiorno.");
			break;

			case 3:
			// Spanish/Español
			System.out.println("Buenos dias.");
			break;

			case 4:
			// German/Deutsch
			System.out.println("Guten morgen.");
			break;

			case 5:
			// The program will end
			System.out.println("This program will now end.");
			break;
		}
	}
}

