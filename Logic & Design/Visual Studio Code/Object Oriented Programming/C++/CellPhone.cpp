#include <iostream>
#include <string>
using namespace std;

class CellPhone
{
private:
    string manufacturer;
    string modelNumber;
    double retailPrice;

public:
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
    myPhone.setModelNumber("M1000");
    myPhone.setRetailPrice(199.99);

    cout << "The manufactuer is " << myPhone.getManufacturer() << endl;
    cout << "The model number is " << myPhone.getModelNumber() << endl;
    cout << "The retail price is " << myPhone.getRetailPrice() << endl;

    system("Pause");
    return 0;
}