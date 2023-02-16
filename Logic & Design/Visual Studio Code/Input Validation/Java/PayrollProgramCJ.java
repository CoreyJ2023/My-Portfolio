/**Documentation
	Chapter 7
	Programming Exercise 1: Payroll Program with Input Validation
	Programmer: Corey Jenkins    Date: 04-05-2017
	Description: To calculate hours and payroll, but using a while loop to prevent any numbers less than or
	greater than the range of numbers for each.
**/

// Let's import the scanner for keyboard input
import java.util.Scanner;

public class PayrollProgramCJ
{
	public static void main(String[] args)
	{
		// Let's enter our scanner for keyboard input.
		Scanner keyboard = new Scanner(System.in);

		showResults();
	}

	// Let's put in our module or function.
	public static void showResults()
	{
		// Let's enter our scanner for keyboard input.
		Scanner keyboard = new Scanner(System.in);

		// Assign a variable "hours" as an integer.
		// Integers are used for whole numbers only.
		int hours;

		// Assign the variables "hourlyPay" and "totalPay"
		double hourlyPay, totalPay;

		// Input the amount of hours worked
		System.out.print("How many hours worked? ");
		hours = keyboard.nextInt();

		// With a "while" loop, a conditional, if you input a number that is
		// less than 0 OR greater that 40, the following message below
		// will prevent you from entering it.
		while (hours < 0 || hours > 40)
		{
			System.out.println("Sorry. You must enter hours between 0 and 40");
			System.out.println("Please enter the hours again. ");
			hours = keyboard.nextInt();
		}

		// Input the pay amount.
		System.out.print("What is the pay? ");
		hourlyPay = keyboard.nextDouble();

		// With a "while" loop, a conditional, if you input a number that is
		// less than $7.50 OR greater than $18.25, the following message below
		// will prevent you from entering it.
		while (hourlyPay < 7.50 || hourlyPay > 18.25)
		{
			System.out.println("Sorry. You must enter hours that are between");
			System.out.println("7.50 and 18.25. Try again.");
			hourlyPay = keyboard.nextDouble();
		}

		// With math, "totalPay" will be the variable that will give us the product
		// of "hour" times "hourlyPay".
		totalPay = hours * hourlyPay;

		// This will give out the answer.
		System.out.println("The total amount is " + totalPay);
	}
}



