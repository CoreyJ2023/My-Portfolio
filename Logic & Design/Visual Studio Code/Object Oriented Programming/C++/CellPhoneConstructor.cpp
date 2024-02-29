/*
 * Programmer:   Corey Jenkins
 * Date:         February 29, 2024
 * Filename:     CellPhoneConstructor.cpp
 * Purpose:      Object-Orientied Programming with a Constructor.
*/

#include <iostream>
#include <string>
using namespace std;

class CellPhoneConstructor
{
    private:
        string manufacturer;
        string modelNumber;
        double retailPrice;

    // Create a constructor.
    public:
        CellPhoneConstructor(string manufact, string model, double retail)
        {
            manufacturer = manufact;
            modelNumber = model;
            retailPrice = retail;
        }

    // Mutators or setters.
    void setManufacturer(string manufact)
    {
        manufacturer = manufact;
    }

    void setModelNumber(string model)
    {
        modelNumber = model;
    }

    void setRetailPrice(double retail)
    {
        retailPrice = retail;
    }

    // Accessor or Getters.
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
    CellPhoneConstructor myPhone("Motorolla", "M1000", 199.99);

    cout << "The manufacturer is: " << myPhone.getManufacturer() << endl;
    cout << "The model number is: " << myPhone.getModelNumber() << endl;
    cout << "The retail price is: " << myPhone.getRetailPrice() << endl;

    return 0;
}