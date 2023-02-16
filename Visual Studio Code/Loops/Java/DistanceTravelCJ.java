/**Documentation
	Chapter 5
	Programming Excercise 06: Distance Traveled
	Programmer: Corey Jenkins    Date: 03-22-2017
	Purpose: to create a program using a module, that calculates the distance of a vehicle using this formula: Distance = Speed * Time
**/

import java.util.Scanner;

public class DistanceTravelCJ
{
	public static void main(String[] args)
	{
		//To call it back, we will assign this module as "finalResults."
		finalResults();
	}

	public static void finalResults()
	{
		Scanner keyboard = new Scanner(System.in);

		//Let's enter a few variables
		int speed, hour, distance;

		// Final variable
		final int MAX_VALUE = 3;

		System.out.print("What is the speed of the vehicle in MPH: ");
		speed = keyboard.nextInt();

		System.out.print("And how many hours has it traveled: ");
		hour = keyboard.nextInt();

		// Let's make a table heading
		System.out.println("Hour\tDistance Traveled"); // This will add the spacing of "hour" and "Distance Traveled".
		System.out.println("-----------------------"); // this will add a line.


		//Let's make a loop
		for (hour = 1; hour <= MAX_VALUE; hour++)
		{
			distance = speed * hour;
			System.out.println(hour + "\t\t" + distance);
		}
	}
}





