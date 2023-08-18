/*
*	Programmer:			Corey Jenkins
*	Date:				August 17, 2023
*	Filename:			areaRectangleFunction.cpp
*   Purpose:			A program in which returns the area of a rectangle.
*/

#include <iostream>
#include <string>
using namespace std;

int area(int, int);

int main()
{
	int rectangleLength, rectangleWidth, areaReturnFunction;
	cout << "Enter the length of the rectangle: " << endl;
	cin >> rectangleLength;

	cout << "Enter the width of the rectangle: " << endl;
	cin >> rectangleWidth;

	areaReturnFunction = area(rectangleLength, rectangleWidth);
	cout << "The area of the rectangle is " << areaReturnFunction << endl;

	system("pause");
	return 0;
}

int area(int num1, int num2)
{
	int result;
	result = num1 * num2;
	return result;
}