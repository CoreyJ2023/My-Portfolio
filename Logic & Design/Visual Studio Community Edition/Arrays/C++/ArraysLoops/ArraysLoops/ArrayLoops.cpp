/*
 Programmer:		Corey Jenkins
 Date:				April 18, 2021
 Program Name:		ArrayLoops.cpp
 Purpose:			A demonstration on using for loops with arrays.
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
	const int SIZE = 3;
	int hours[SIZE];

	int index;

	for (index = 0; index <= SIZE - 1; index++)
	{
		cout << "Enter the amount of hours for employee # " << (index + 1) << ":" << endl;
		cin >> hours[index];
	}

	for (index = 0; index <= SIZE - 1; index++)
	{
		cout << "The hours entered for employee # " << (index + 1) << ": " << hours[index] << endl;

	}

	system("pause");
	return 0;
}