/*
*   Programmer:     Corey Jenkins 
*   Program Date:   February 21, 2021
*   Program Name:   Common Core.cpp
*   Purpose:        Creating a common core program in C++.
*/


#include <iostream>
#include <string>
#include <cstdlib>
using namespace std;

void commonCore();
void showSum(int, int);

int main()
{
    int SophieJumps = 12;
    int TylerJumps = 9;
    int answer;
    
    cout << "Sophie jumped on one foot 12 times in a row." << endl;
    cout << "Tyler jumped on one foot 9 times." << endl;
    cout << "How many more jumps did Sophie jump ?" << endl;

    answer = SophieJumps - TylerJumps;

    cout << "The answer is, " << answer << "." << endl;
    cout << "But that's too easy. So, let's take it up a notch." << endl;

    commonCore();

    system("pause");
    return 0;
}

void commonCore()
{
    cout << "With Common Core, we need to split 9 into two numbers and when subtracted by 12 will give us 3" << endl;
    cout << "12 - 8 will become ((12 - (7) - 2) or 7 and 2" << endl;
    showSum(7, 2);
}


void showSum(int num1, int num2)
{
    int remainingNumber = 12;
    int firstPart;
    int commonCoreAnswer;

    firstPart = remainingNumber - num1;
    commonCoreAnswer = firstPart - num2;

    cout << "The answer to this Common Core problem is, " << commonCoreAnswer << "." << endl;
    cout << "A different but more interesting logic. The answer's the same.";
}