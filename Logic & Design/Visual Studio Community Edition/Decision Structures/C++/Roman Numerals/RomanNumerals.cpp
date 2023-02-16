/*
* Programmer:		Corey Jenkins
* Date:				February 8, 2023
* Filename:			RomanNumerals.cpp
* Purpose:			To create a program that gives an error if a Roman Numeral is used outside I through X
*/

// Directives 
#include <iostream>
#include <string>
using namespace std;

void RomanNumerals();

int main()
{
	RomanNumerals();
	system("Pause");
	return 0;
}

void RomanNumerals()
{
	int romanNumeral;

	cout << "Enter a number between 1 to 10: " << endl;
	cin >> romanNumeral;

	switch (romanNumeral)
	{
	case 1:
		cout << "I" << endl;
		break;

	case 2:
		cout << "II" << endl;
		break;

	case 3:
		cout << "III" << endl;
		break;

	case 4:
		cout << "IV" << endl;
		break;

	case 5:
		cout << "V" << endl;
		break;

	case 6:
		cout << "VI" << endl;
		break;

	case 7:
		cout << "VII" << endl;
		break;

	case 8:
		cout << "VIII" << endl;
		break;

	case 9:
		cout << "XI" << endl;
		break;

	case 10:
		cout << "X" << endl;
		break;

	default:
		cout << "An error has occurred." << endl;
		break;
	}

}