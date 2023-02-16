import java.util.Scanner;

public class RecursiveFactorial
{
	public static void main(String[] args)
	{
		int number; 	// To hold a number

		// Create a Scanner object for keyboard input.
		Scanner keyboard = new Scanner(System.in);

		// Get a number from the user.
		System.out.print("Enter a non-negative integer: ");
		number = keyboard.nextInt();

		// Display the factorial of the number.
		System.out.println("The factorial of " + number + " is " + factorial(number));
	}


	// The factorial method uses recursion to calculate
	// the factorial of its argument, which is assumed
	// to be a nonnegative number.

	private static int factorial(int n)
	{
		if (n == 0)
			return 1;	// Base case
		else
			return n * factorial(n - 1);
	}
}