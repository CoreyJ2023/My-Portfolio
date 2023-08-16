'''
Programmer:     Corey Jenkins
Date:           August 15, 2023
Filename:       feet_to_inches_function.py
Purpose:        To input feet and with a function to return it to inches.
'''

def main():
    
    feet_input = float(input("Enter the amount of feet (distance): "))
    convert_to_inches = feet(feet_input)
    print("Feet to inches: ", convert_to_inches)

# Function. To take how many feet (distance) in and divided by 12. 1 foot equals twelve inches.
def feet(num1):
    result = num1 / 12
    return result
    
main()