/*
*	Programmer:			Corey Jenkins
*	Date:				September 25, 2018 (Updated on January 17, 2023)	
*	Filename:			LangaugeSelect.cpp
*	Purpose:			A demonstration in using the case/switch to select a language.
*/

#include<iostream>
#include<string>

using namespace std;

int main()
{
	cout << "Select a langauge!" << endl;
	cout << "1 - English" << endl;
	cout << "2- French" << endl;
	cout << "3 - Spanish" << endl;
	cout << "4 - German" << endl;
	cout << "5 - Kouri-Vini" << endl;
	cout << "6 - Ukrainian" << endl;

	int language;
	cin >> language;

	switch (language)
	{
	case 1: 
		cout << "You have chosen English." << endl;
		break;

	case 2:
		cout << "You have chosen French! Bonjour !" << endl;
		break;

	case 3:
		cout << "You have chosen Spanish! ¡Hola!" << endl;
		break;

	case 4:
		cout << "You have chosen German! Hallo! " << endl;
		break;

	case 5:
		cout << "You have chosen Kouri-Vini. Bonjou!" << endl;
		break;

	case 6:
		cout << "You have chosen Ukrainian." << endl;
		break;

	default:
		cout << "You have made an illegal choice!" << endl;
	}

	system("pause");
	return 0;

}