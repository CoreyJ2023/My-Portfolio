/*
* Programmer:			Corey Jenkins
* Filename:				ModuleStruct.cpp
* Date:					October 17, 2022
* Purpose:				Making a struct and using modules or functions to give a game a name and age for two consoles.
*/

#include <iostream>
#include <string>
using namespace std;

struct myGame
{
	string name;
	int age;
};

void nintendo()
{
	myGame AwesomeGame;
	AwesomeGame.name = "Legends of the Hidden Forest";
	AwesomeGame.age = 6;
	cout << "This game is for the Nintendo Switch called " << AwesomeGame.name << endl;
	cout << "This game is for players of " << AwesomeGame.age << " age and older." << endl;
}

void playstation()
{
	myGame AwesomeGame2;
	AwesomeGame2.name = "The Hidden Valley";
	AwesomeGame2.age = 13;
	cout << "This game for the Playstation is called " << AwesomeGame2.name << endl;
	cout << "This game is for those " << AwesomeGame2.age << " years of age and older." << endl;
}

int main()
{
	nintendo();
	playstation();
	system("pause");
	return 0;
}