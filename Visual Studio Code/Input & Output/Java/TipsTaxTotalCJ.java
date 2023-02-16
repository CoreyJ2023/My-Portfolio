/**Documentation
	Chapter 2
	Programming exercise 8: Tips, Tax and Total
	Programmer: Corey Jenkins    Date: 08-16-2017
	Description: To create a program that calculates tips, tax, and the total amount for each.
**/

// Import the scanner in order to put numbers into assigned variables.
import java.util.Scanner;

	public class TipsTaxTotalCJ
	{
		public static void main(String args[])
		{
			// Declare variables in the following: charge, total, tipsTotal, taxTotal, addTips,
			// addTax and tipsAndTax
			double charge; //The charge price for the food.
			double total; //variable for total - we're going to need this to total everything up.
			double tipsTotal; //variable to add the total with the price and tips combined
			double taxTotal; //Variable to add both the price and tax
			double addTips; //Variable used once the tip percentage is multiplied and then add to get the amount including the tips
			double addTax; //Variable used once the sales tax is multiplied with the charging price of the meal to get the total amount, tax included.
			double tipsAndTax; //Variable assigned for x = (price)*(0.07)

			// input decimals for the variables of tips and tax
			double tips = 0.15; // for tips, let's identify the variable "tips" to be as the decimal number 0.15 or 15%
			double tax = 0.07; // for taxes, let's identify the variable "tax" to be as the decimal number of 0.07 or 7%

			// Bring out the scanner to imput numbers in the variables below.
			Scanner keyboard = new Scanner(System.in);

			// With charge as the varible, put in the amount for the varible to hold in.
			System.out.println("What is the charge for the meal?");
			charge = keyboard.nextDouble();

			// Here, we will use simple math (and the order operations) to get
			// an answer to each variable listed below.
			addTips = (charge)*(tips); // addtax is when you use that number when you multiply the sales tax with the price.
			tipsTotal= (charge)+(addTips); // to get the price, tips included, one must use that number (addtax) with the price.
			addTax = (charge)*(tax); // multiply the price added with the variable tax, which is assigned as 0.07.
			taxTotal = (charge)+(addTax); // x = (price)+(addTax) the number that results from multiplying 0.07 with the charge price
			tipsAndTax = (charge)*((tips)+(tax));
			total = (charge)+(tipsAndTax);


			System.out.println("With the inclusion of tips the total amount is " + tipsTotal); // Decimal form.
					System.out.println("");
			 		System.out.printf("With the inclusion of tips, the total amount is %,.0f", tipsTotal);// Rounds to the nearest whole number.
			 		System.out.println("");

			System.out.println("With the inclusion of tax, the total amount is " + taxTotal);// Decimal form.

					System.out.println("");
					System.out.printf("With the inclusion of tax, the total amount is %,.0f", taxTotal); // rounds to the nearest whole number.
					System.out.println("");

			System.out.println("With the inclusion of both tips and tax, the total amount is " + total);

					System.out.println("");
					System.out.printf("With the inclusion of both tips and tax, the total amount is %,.0f", + total); // rounds to the nearest whole number.

					System.out.println("");

		}
	}