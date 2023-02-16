/*
	Programmer:			Corey Jenkins
	Date:				April 9, 2021
	Program Name:		CellPhone.cpp
	Purpose:			An introduction to Object Oriented Programming.
*/


#include <iostream>
#include <string>
using namespace std;

// For OOP or for classes you start with class

class CellPhone
{
private:
	// Field declarations
	string manufacturer;
	string modelNumber;
	double retailPrice;
public:
	//Member function
	void setManufacturer(string manufact)
	{
		manufacturer = manufact;
	}

	void setModelNumber(string modNum)
	{
		modelNumber = modNum;
	}

	void setRetailPrice(double retail)
	{
		retailPrice = retail;
	}

	// The getters
	string getManufacturer()
	{
		return manufacturer;

	}

	string getModelNumber()
	{
		return modelNumber;
	}

	double getRetailPrice()
	{
		return retailPrice;
	}
};

int main()
{
	CellPhone myPhone;

	myPhone.setManufacturer("Motorola");
	myPhone.setModelNumber("M100");
	myPhone.setRetailPrice(199.99);

	// Display the values stored in the fields
	cout << "The manufacuter is " << myPhone.getManufacturer() << endl;
	cout << "The model number is " << myPhone.getModelNumber() << endl;
	cout << "The retail price is " << myPhone.getRetailPrice() << endl;

	system("pause");
	return 0;
}