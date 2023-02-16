/*
	Programmer:		Corey Jenkins
	Date:			April 19, 2021
	Program Name:	Arrays.cpp
	Purpose:		A demonstation on using arrays in C++
*/


#include <iostream>
#include <string>
using namespace std;

int main()
{
	const int SIZE = 3;
	int hours[SIZE];

	cout << "Enter the number of hours for employee #1:" << endl;
	cin >> hours[0];

	cout << "Enter the number of hours for employee #2:" << endl;
	cin >> hours[1];

	cout << "Enter the number of hours for employee #3:" << endl;
	cin >> hours[2];

	cout << "The number of hours for employees #1, #2, and #3 are as follows" << endl;
	cout << hours[0] << hours[1] << hours[2] << endl;

	system("pause");
	return 0;
}