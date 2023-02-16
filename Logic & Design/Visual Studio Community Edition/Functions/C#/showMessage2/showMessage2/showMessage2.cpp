/*
 * Programmer:      Corey Jenkins
 * Date             March 30, 2022
 * Program Name     showMessage2.cpp
 * Purpose:         A demonstration on modules when giving instructions on how to dissasemble an ACME laundry dryer.
*/

#include <iostream>
#include <string>
using namespace std;

void startingMessage();
void step1();
void step2();
void step3();
void step4();

int main()
{
	startingMessage();
	string input;
	cout << "Press a key to see Step 1.\n" << endl;
	system("pause");

	step1();
	cout << "Press a key to see Step 2.\n" << endl;
	system("pause");

	step2();
	cout << "Press a key to see Step 3.\n" << endl;
	system("pause");
	
	step3();
	cout << "Press a key to see Step 4.\n" << endl;
	system("pause");
	
	step4();
	
	system("pause");
	return 0;
	
}

void startingMessage()
{
	cout << "This program tells you." << endl;
	cout << "how to disassemble an ACME dryer" << endl;
	cout << "There are four steps in this process." << endl;
}

void step1()
{
	cout << "Step 1: Unplug the dryer and" << endl;
	cout << "move it away from the wall." << endl;
}

void step2()
{
	cout << "Step 2: Remove the six screws" << endl;
	cout << "from the back of the dryer." << endl;
}

void step3()
{
	cout << "Step 3: Remove the dryer's" << endl;
	cout << "back panel." << endl;
}

void step4()
{
	cout << "Step 4: Pull the top of the" << endl;
	cout << "dryer staight up." << endl;
}