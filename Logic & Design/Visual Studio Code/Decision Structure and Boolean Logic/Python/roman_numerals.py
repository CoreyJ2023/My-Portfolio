'''
Programmer:         Corey Jenkins
Date:               February 8, 2023
Filename:           roman_numerals.py
Purpose:            To create a program that gives an error if a roman numeral is used outside I through X
'''

def main():
    the_roman_numerals()
    
def the_roman_numerals():
    '''
    The pseudocode for this program uses case/switch. So, a while loop will be used for input validation.
    And an if/else statement will be used.
    '''
    
    roman_numeral = int(input("Enter a number between 1 to 10: "))
    while(roman_numeral < 0 or roman_numeral > 10):
        print("ERROR!")
        roman_numeral = int(input("Enter a number between 1 to 10: "))
        
    if(roman_numeral == 1):
        print("I")
    elif(roman_numeral == 2):
        print("II")
    elif(roman_numeral == 3): 
        print("III")
    elif(roman_numeral == 4):
        print("IV")
    elif(roman_numeral == 5):
        print("V")
    elif(roman_numeral == 6):
        print("VI")
    elif(roman_numeral == 7):
        print("VII")
    elif(roman_numeral == 8):
        print("VIII")
    elif(roman_numeral == 9):
        print("IX")
    elif(roman_numeral == 10):
        print("X")
        
main()