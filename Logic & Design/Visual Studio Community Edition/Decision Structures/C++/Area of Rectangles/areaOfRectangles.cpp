/*
* Programmer:		Corey Jenkins
* Date:				February 8, 2023
* Filename			AreaOfRectangles.cpp
* Filename:			To create a program that inputs the area of two rectangles
	and determine if both are the same or not.
*/

#include <iostream>
#include <string>
using namespace std;

void rectangles();
void areaOfRectangles(int num1, int num2);

int main()
{
	rectangles();
	system("pause");
	return 0;
}

void rectangles()
{
	int length1, width1;
	int length2, width2;
	int areaOfRectangle1, areaOfRectangle2;

	cout << "Enter the length of rectangle 1: " << endl;
	cin >> length1;

	cout << "Enter the width of rectangle 1: " << endl;
	cin >> width1;

	areaOfRectangle1 = length1 * width1;

	cout << "Enter the length of rectangle 2: " << endl;
	cin >> length2;

	cout << "Enter the width of rectangle 2: " << endl;
	cin >> width2;

	areaOfRectangle2 = length2 * width2;

	areaOfRectangles(areaOfRectangle1, areaOfRectangle2);
}

void areaOfRectangles(int num1, int num2)
{
	if(num1 == num2)
	{
		cout << "Yes! They are the same dimensions." << endl;
	}
	else
	{
		cout << "No! They are not the same dimensions." << endl;
	}
}