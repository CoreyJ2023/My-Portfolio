'''
Programmer:		Corey Jenkins
Date:			August 28, 2019
Program Name:   common_core.py
Purpose:		To use different logics in the ways of programming.
'''

# Modules or function is used to organize the code into multiple sections making it easier for programmers to look into
def main():

    print("Sophie jumped on one foot 12 times in a row. Tyler jumped on one foot 9 times. How many more jumps did Sophie jump?")
     
    # number1 and number2 are variables in which you can put something in, like an item inside a box.
    number1 = (12) 
    number2 = (9) 
    #This formula is bascially 12 - 9 
    simple_answer = (number1) - (number2) 

    print("The answer is,", simple_answer, ".... but that's too easy! Let's crank it up a notch!")

    # Let's try the Common Core Method with a random function implemented.
    common_core()

def common_core():
    import random
    # The Common Core variance of this problem.
    # Using the random function, it will generate two random numbers between 2 and 7.
    print("We will then randomize two numbers and will loop until the solution is found!")
    mystery_number1 = random.randint(2, 7)
    mystery_number2 = random.randint(2, 7)
    
    # This is a while loop. If the two numbers DOES not equal 7 and 2, it will not continue.
    # And will loop UNTIL these numbers are found!
    while(mystery_number1 != (7)) & (mystery_number2 != (2)):
        
        print("It seems that these numbers of ", mystery_number1,"and", mystery_number2, "won't work. Generating two more random numbers.")
        mystery_number1 = random.randint(2, 7)
        mystery_number2 = random.randint(2, 7)

    # If successful as in mystery_number 1 == 7 and mystery_number == 2
    print("The numbers are indeed 7 and 2!")
    show_num(7, 2)

# Carrying 7 and 2 down to this module to be calculated. It should be 3!
def show_num(num1, num2):
    number1 = (12)
    solution1 = (12) - (num1)
    complex_answer = (solution1) - (num2)

    print("The answer is,", complex_answer, ". The same answer under a different, more interesting logic!") 
main()