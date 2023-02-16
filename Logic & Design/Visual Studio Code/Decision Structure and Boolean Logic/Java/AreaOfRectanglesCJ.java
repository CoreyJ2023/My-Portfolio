// Import the scanner
import java.util.Scanner;

public class AreaOfRectanglesCJ
{
	public static void main(String[] args)
	{
		//Bring out the keyboard scanner
		Scanner keyboard = new Scanner(System.in);

		// Variables to put in the width and length for two rectangles.
		// width1 and length1 for the first rectangle
		// and width2 and length2 for the second triangle.
		double widthOne;
		double lengthOne;
		double widthTwo;
		double lengthTwo;
		double rectangle1;
		double rectangle2;

		rectangle1 = getRectangle1(width1, length1);
		rectangle2 = getRectangle2(width2, length2);

		System.out.print("What is the width of the 1st rectangle?");
		widthOne = keyboard.nextDouble();

		System.out.print("What is the length of the 1st rectangle?");
		lengthOne = keyboard.nextDouble();

		System.out.print("What is the width of the 2nd rectangle?");
		widthTwo = keyboard.nextDouble();

		System.out.print("what is the length of the 2nd rectangle?");
		lengthTwo = keyboard.nextDouble();

		if (rectangle1 == rectangle2)
				System.out.println("The area of the two rectangles are the same.");
		else
				System.out.println("The area of the two rectangles are NOT the same.");
	}

	public static double getRectangle1(double width1, double length1)
	{
		double result1;
		result1 = width1 * length1;
		return result1;
	}

	public static double getRectangle2(double width2, double length2)
	{
		double result2;
		result2 = width2 * length2;
		return result2;
	}
}







