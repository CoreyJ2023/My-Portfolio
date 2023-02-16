/**Documentation
	Chapter 8
	Programming Exercise 1: Total Sales
	Programmer: Corey Jenkins    Date: 10-13-2017
	Description: To use a loop to calculate the total sales for the week and display the results
**/

import java.util.Scanner;

public class TotalSalesCJ
{
	public static void main(String[] args)
	{
		showMessage();
	}

	public static void showMessage()
	{
		// Create a keyboard scanner
		Scanner keyboard = new Scanner(System.in);

		// Create a constant for the days of the week, being 7
		final int WEEKS = 7;

		// Declare an array to hold the sales number
		int [] sales = new int [WEEKS];

		// Declare a variable to use loops
		int index;

		// The accumulator, which is set to 0.
		int total = 0;

		// Get the number of sales for each week
		for (index = 0; index <= WEEKS - 1; index++)
		{
			System.out.print("Enter the sales number for "  + "day " + (index + 1) + ": ");
			sales[index] = keyboard.nextInt();
			total = total + sales[index];
		}
			System.out.println(total);

	 }
 }