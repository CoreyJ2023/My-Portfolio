/*
* Programmer:		Corey Jenkins
* Filename:			Stucture2.cpp
* Date:				September 23, 2022
* Purpose:			A second demonstration of using stuctures in C++
*/

#include <iostream>
#include <string>
using namespace std;


enum Person { human, robot, alien }; // The Enumrators, when called, being an array, goes 0, 1, and then 2.

struct character
{
	string name;
	string like;
	string dislike;
	unsigned char type;
};

int main()
{
	character MyCharacter;
	MyCharacter.name = "Lest";
	MyCharacter.like = "donations and knowledge.";
	MyCharacter.dislike = "Corporate greed. Corruption.";
	MyCharacter.type = human;
	cout << MyCharacter.name << " is a " << (int)MyCharacter.type << endl; // is a type 0 for human.
	cout << MyCharacter.name << "'s like are " << MyCharacter.like <<  endl;
	cout << MyCharacter.name << "'s dislike are " << MyCharacter.dislike << endl;
	cout << MyCharacter.name << "s' age is a mystery." << endl;

	system("Pause");
	return 0;
}