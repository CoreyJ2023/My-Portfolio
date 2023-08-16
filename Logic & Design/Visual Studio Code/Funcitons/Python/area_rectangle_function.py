'''
Programmer:     Corey Jenkins
Date:           August 15, 2023
Filename:       area_rectangle_function.py
Purpose:        A program in which returns the area of a rectangle.
'''

def main():
    rectangle_length = int(input("Enter the length:"))
    rectangle_width = int(input("Enter the widtht:"))
    area_function = area(rectangle_length, rectangle_width)
    print("Area is", area_function)
    
# Function. Will multiply to give the area and will return the results back to area_function in the Main module.
def area(num1, num2):
    result = (num1 * num2)
    return result
    
main()