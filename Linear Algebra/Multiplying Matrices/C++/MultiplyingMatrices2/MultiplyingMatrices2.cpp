/*
* Programmer:		Corey Jenkins
* Date:				August 31, 2022
* Program Name:		MultiplyingMatrices.cpp
* Purpose:			A second demonstration of multiplying matrices in C++
*/

#include <iostream>
#include <string>
using namespace std;

int main()
{
    /*These variables will give the product for the coordinates on the X, Y, and Z axis.
    [(2 -1 0), (3 2 -1), (-3, 1, 2)] and [(1,4,3)] Multiply then add. Dot
     Product.
    */
    int PointX, PointY, PointZ;
    PointX = (2 * 1) + (-1 * 4) + (0 * 3);
    PointY = (3 * 1) + (2 * 4) + (-1 * 3);
    PointZ = (-3 * 1) + (1 * 4) + (2 * 3);

    cout << "The Solution is: " << "[" << PointX << "," << PointY << "," << PointZ << "]." << endl;

    system("pause");
    return 0;
}