'''
Programmer:         Corey Jenkins
Date:               August 30, 2022
Program Name:       mutliplying_matrices1.py
Purpose:            A demonstration of mutlplying matrices in Python.
'''
def main():
    math_problem_1()
    math_problem_2()

def math_problem_1():
    
    # Let's give [1 3] [-5 2] with [2 2] that being for X and Y
    point_x = (1*2) + (3*2)
    point_y = (-5*2) + (2*2)
        
    print("The solution is: [",point_x,point_y,"]")
                         
def math_problem_2():
    point_x = (2 * 5) + (-2 * 5)
    point_y = (3 * 5) + (-2 * 5)        
    print("The solution is: [",point_x,point_y,"]")
            
main()
    
