/**Documentation
	Chapter 5
	Programming Excercise 01: Bug Collector
	Programmer: Corey Jenkins    Date: 03-22-2017
	Purpose: to create a program using a module, that runs a loop of seven days
	and putting in how many bugs you've collected a day.
**/

// Let's import the Scanner for keyboard input later
import java.util.Scanner;

public class BugCollectorCJ
{
	public static void main(String[] args)
	{
		// Let's create a module that will call it back once the program is executed
		// and to break the program into two parts.
		// Display the total amount of bugs
		System.out.println("Insert the amount of bugs you've collected for seven days");
		totalBugs();
	}

	// let's create totalBugs module to call it back once the program is executed.
	public static void totalBugs()
	{
		//Bring in the scanner for keyboard input
		Scanner keyboard = new Scanner(System.in);

		// Bring three variables. Two of which we'll assign for "days" as a counter and the "bugs"
		// variable to input the amount collected within seven days.

		int bugs, days;

		// The total will begin at zero and will add up.
		int total = 0;


		// using a for loop, the first day is set to 1 and will loop until it reaches the 7th day
		// which is 7.
		for(days = 1; days <= 7; days++)
		{
			// With the for loop, enter a number of bugs you have collected
			// and it will add up for seven days.
			System.out.println("Bugs collected.");
			bugs = keyboard.nextInt();
			total = total + bugs;
		}
		// The results.
		System.out.println("The amount of bugs collected within seven days are, " + total);
	}
}



