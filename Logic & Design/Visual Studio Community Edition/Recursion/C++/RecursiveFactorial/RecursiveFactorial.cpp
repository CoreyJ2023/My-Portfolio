/*
	Programmer:		Corey Jenkins
	Date:			April 29, 2017
	Filename:		RecursionDemo
	Purpose:		A demonstration of recursion.
*/

#include <iostream>
#include <string>
using namespace std;

// We want the factorial function to be made after the main function.
int factorial(int n);

int main()
{
	int number;

	cout << "Enter a non-negative number" << endl;
	cin >> number;
	
	// This is added by me and not in the pseudocode document. Input Validation.
	while (number < 0)
	{
		cout << "You have entered a negative number!" << endl;
		cout << "Enter a non-negative number:" << endl;
		cin >> number;
	}
	

	cout << "the factorial of " << number << " is " << factorial(number) << "." << endl;

	system("pause");
	return 0;
}

int factorial(int n)
{
	if (n == 0)
	{
		return 1; // This will turn out to be 1.
	}
	else
	{
		return n * factorial(n - 1);
	}
}