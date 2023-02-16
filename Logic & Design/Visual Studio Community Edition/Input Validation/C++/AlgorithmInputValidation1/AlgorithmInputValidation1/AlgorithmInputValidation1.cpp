#include <iostream>
#include <string>
using namespace std;

int main()
{
	int nonZeroNumber;

	cout << "enter a nonzero number." << endl;
	cin >> nonZeroNumber; 

	while (nonZeroNumber < 1)
	{
		cout << "You've entered a non-zero number. The number is: " << nonZeroNumber << endl;
	
		cout << "Enter a nonzero number." << endl;
		cin >> nonZeroNumber;

	}

	cout << "This is a non-zero number: " << nonZeroNumber << endl;
}