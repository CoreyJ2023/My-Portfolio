/*
* Programmer:		Corey Jenkins
* Date:				January 23, 2023.
* Filename:			Algorithm2.cpp
* Purpose:			Menu-Driven Programming with the use of a While-loop and a Case/Switch
*/

#include <iostream>
#include <string>
using namespace std;


// If you want the main function to come before other functions, you have to declare them here in C++.
void Menu();
void OpenDocument();
void CloseDocument();
void PrintDocument();

// Main function. Will call the Menu Function.
int main()
{
	Menu();
	system("pause");
	return 0;
}

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

	// Loop to MenuSelection if it is not numbers 1 through 4.
	while (MenuSelection < 1 || MenuSelection > 4)
	{
		cout << "This is an invalid selection." << endl;
		cout << "Please select 1, 2, 3, or 4!" << endl;
		cin >> MenuSelection;
	}

	// Case/Switch. A function is placed for each and will call once selected.
	switch (MenuSelection)
	{
	case 01:
		OpenDocument();
		break;

	case 02:
		CloseDocument();
		break;

	case 03:
		PrintDocument();
		break;

	case 04:
		cout << "Exiting the program." << endl;
	}
}

// Function OpenDocument. Case 01
void OpenDocument()
{
	cout << "Opening the document!" << endl;
}

// Function ClosingDocument. Case 02
void CloseDocument()
{
	cout << "Closing the document!" << endl;
}

// Function PrintDocument Case 03.
void PrintDocument()
{
	cout << "Printing the document!" << endl;
}

