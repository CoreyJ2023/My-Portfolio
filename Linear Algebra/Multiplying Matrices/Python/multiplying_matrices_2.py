'''
Programmer:        Corey Jenkins
Date:              August 31, 2022
Program Name:      multiplying_matrices2.py
Purpose:           A demonstration on multplying matrices in Python. Run this program in Visual Studio Code.
'''



def main():
    
    # These variables will give the product for the coordinates on the X, Y, and Z axis.
    # [(2 -1 0), (3 2 -1), (-3, 1, 2)] and [(1,4,3)] Multiply then add. Dot Product.
    # Set 1
    point_x = (2*1) + (-1*4) + (0*3)
    point_y = (3*1) + (2*4) + (-1*3)
    point_z = (-3*1) + (1*4) + (2*3)
    
    print("The solution is: [",point_x,point_y,point_z, "]")

main()
    