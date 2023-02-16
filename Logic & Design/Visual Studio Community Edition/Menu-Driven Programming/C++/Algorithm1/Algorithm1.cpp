/*
* Programmer:		Corey Jenkins
* Date:				January 22, 2023
* Filename:			Algorithm1.cpp
* Purpose:			An algorithm involving input validation using if/else statements.
*/

#include <iostream>
#include <string>
using namespace std;

void Menu()
{
	int MenuSelection;
	cout << "This is the main menu." << endl;
	cout << "1. Open a menu." << endl;
	cout << "2. Close the current document." << endl;
	cout << "3. Print the current document. " << endl;
	cout << "4. Exiting the program." << endl;

	cout << "Enter your selection: " << endl;
	cin >> MenuSelection;

	if (MenuSelection == 1)
	{
		cout << "Opening the document." << endl;
	}
	else if (MenuSelection == 2)
	{
		cout << "Closing the document." << endl;
	}
	else if (MenuSelection == 3)
	{
		cout << "Printing the document." << endl;
	}
	else if (MenuSelection == 4)
	{
		cout << "Exiting the program." << endl;
	}
	else
	{
		cout << "That is an invalid selection." << endl;
	}
}

int main()
{
	Menu();
	system("pause");
	return 0;
}


