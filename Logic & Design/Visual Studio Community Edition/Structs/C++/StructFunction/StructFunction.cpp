/*
* Programmer:		Corey Jenkins
* Filename			StructFunciton.cpp
* Date:				September 27, 2022
* 
*/

#include <iostream>
#include <string>
using namespace std;

// Functions - three cows.
void cow1();
void cow2();
void cow3();

const enum COW_TYPE { dairy, pet, hide }; // Types of cows

struct Cow
{
	string name;
	int age;
	unsigned char purpose;
};

int main()
{
	cow1();
	cow2();
	cow3();

	system("pause");
	return 0;
}

void cow1()
{
	Cow MyCow1;
	MyCow1.name = "Betty";
	MyCow1.age = 5;
	MyCow1.purpose = dairy;

	cout << "This cow's name is " << MyCow1.name << endl;
	cout << "This cow is a type-" << (int)MyCow1.purpose << endl; // Type-0
	cout << "This cow is " << MyCow1.age << " years old." << endl;
}

void cow2()
{
	Cow MyCow2;
	MyCow2.name = "Betty";
	MyCow2.age = 7;
	MyCow2.purpose = pet;

	cout << "This cow's name is " << MyCow2.name << endl;
	cout << "This cow is a type-" << (int)MyCow2.purpose << endl; // Type-1
	cout << "This cow is " << MyCow2.age << " years old." << endl;

}

void cow3()
{
	Cow MyCow3;
	MyCow3.name = "Betty";
	MyCow3.age = 8;
	MyCow3.purpose = hide;

	cout << "This cow's name is " << MyCow3.name << endl;
	cout << "This cow is a type-" << (int)MyCow3.purpose << endl; // Type-2
	cout << "This cow is " << MyCow3.age << " years old." << endl;
}