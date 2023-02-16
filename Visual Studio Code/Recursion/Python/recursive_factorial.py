'''
Programmer:     Corey Jenkins
Date:           January 27, 2022
Program Name:   recursion_demo.py
Purpose:        A demonstration on using a recursive factorial in Python.
'''

# Declare the main module
def main():
    number = int(input("Enter a non-negative number:"))
    
    # This is added by me to demonstrate input validation. It is not in the Pseudocode.
    while(number < 0):
        print("You have entered a negative number.")
        number = int(input("Enter a non-negative number:"))
        
    num_factorial = factorial(number)
    
    print("The factorial of", number, "is", num_factorial)
    
def factorial(n):
    if(n == 0):
        return 1
    else:
        return n * factorial(n - 1)
main()