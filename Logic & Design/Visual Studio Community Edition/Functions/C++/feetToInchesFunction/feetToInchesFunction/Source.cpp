/*
*	Programmer:		Corey Jenkins
*	Date:			August 17, 2023
*	Filename:		feetToInchesFunction.cpp
*	Purpose:		To input feet and with a function to return it to inches.
*/

#include <iostream>
#include <string>
using namespace std;

// Function prototype
double sizeFeet(double);

int main()
{
	double feet, inchesReturn;

	cout << "Enter the amount of feet (distance): " << endl;
	cin >> feet;

	inchesReturn = sizeFeet(feet);
	cout << "Feet to inches: " << inchesReturn << endl;

	system("pause");
	return 0;
}

double sizeFeet(double num1)
{
	double result;
	result = num1 / 12;
	return result;
}