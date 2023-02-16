#include <iostream>
#include <string>
using namespace std;

void MathProblem1();
void MathProblem2();

int main()
{
	MathProblem1();
	MathProblem2();
    system("pause");
    return 0;
}

void MathProblem1()
{
    // Let's give [1 3] [-5 2] with [2 2] that being for X and Y
    int PointX;
    int PointY;
    PointX = (1 * 2) + (3 * 2);
    PointY = (-5 * 2) + (2 * 2);
    cout << "The Solution is: " << "[" << PointX << "," << PointY << "]." << endl;
}

void MathProblem2()
{
    int PointX;
    int PointY;
    PointX = (2 * 5) + (-2 * 5);
    PointY = (3 * 5) + (-2 * 5);
    cout << "The Solution is: " << "[" << PointX << "," << PointY << "]" << endl;
 }
