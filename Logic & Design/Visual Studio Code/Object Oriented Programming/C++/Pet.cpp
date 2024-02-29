/*
* Programmer:       Corey Jenkins 
* Date:             February 18, 2024
* Filename:         Pet.cpp
* Purpose:          An assignment in making an OOP without a constructor involving pets.
*/
#include <iostream>
#include <string>
using namespace std;

class Pet 
{
private:
    string name;
    string type;
    int age; 

public:
    void setName(string nameOfPet)
    {
        name = nameOfPet;
    }

    void setType(string typeOfPet)
    {
        type = typeOfPet;
    }

    void setAge(int ageOfPet)
    {
        age = ageOfPet;
    }

    string getName()
    {
        return name;
    }

    string getType()
    {
        return type;
    }

    int getAge()
    {
        return age;
    }
};

int main()
{
    Pet myPet;

    myPet.setName("Cassandra");
    myPet.setType("dog");
    myPet.setAge(3);

    cout << "The name of the pet is: " << myPet.getName() << endl;
    cout << "The type of the pet is: " << myPet.getType() << endl;
    cout << "The age of the pet is: " << myPet.getAge() << endl;

    system("pause");
    return 0;
}