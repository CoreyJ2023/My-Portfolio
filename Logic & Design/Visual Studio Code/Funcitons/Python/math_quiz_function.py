'''
Programmer:     Corey Jenkins
Date:           August 15, 2023
Filename:       math_quiz_function.py
Purpose:        To create a program in which it shows a math problem at random. Then it will return a function if the answer given was correct or incorrect.
'''

import random
def main():
    
    first_number = random.randint(1, 300)
    second_number = random.randint(1, 300)
    answer_function = sum(first_number, second_number)
    print(answer_function)
    
def sum(first_number, second_number):
    result = first_number + second_number
    print(first_number, "+", second_number)
    answer_input = int(input("Enter your answer: "))
    if result == answer_input:
        print("Correct!")
        return result
    else:
        print('Incorrect!')
        return result
main()
    
    
    