/*
* Programmer:			Corey Jenkins
* Date:					April 19, 2021
* Program Name:			LanguageSelection.cpp
* Purpose:				Menu-Driven Programming in C++
*/


#include <iostream>
#include <string>
using namespace std;

int main()
{
	int language;

	cout << "Select a language:" << endl;
	cout << "1 - English\n";
	cout << "2 - Kouri-Vini\n";
	cout << "3 - Francais\n";
	cin >> language;

	while (language < 0 || language > 3)
	{
		cout << "An error has occured" << endl;
		cout << "Select a language:" << endl;
		cout << "1 - English\n";
		cout << "2 - Kouri-Vini\n";
		cout << "3 - Francais\n";
		cin >> language;
	}

	switch (language)
	{
	case 1:
		cout << "You have selected English!" << endl;
		break;

	/* Certain accent marks such as: é, è, á, and à to name a few does not display correctly in C++
	As such, they will be modified*/
	case 2:
		cout << "To te shwazi langaj kouri-vini!" << endl;
		cout << "Kouri-Vini çe langaj endanjere dan Lalwizyann!" << endl;
		cout << "Mo gran-granparen te parle langaj-cila!" << endl;
		cout << "Aste, ye ti-tigacon c'ap aprenn kouri-vini!" << endl; 
		break;
		
	case 3:
		cout << "Bonjour! C'est francais. Je suis plus meilleur en creole louisianas (le courez-venez) que francais\n";
		cout << "(standard et francais louisianias" << endl;
		break;
	}

	system("pause");
	return 0;
}