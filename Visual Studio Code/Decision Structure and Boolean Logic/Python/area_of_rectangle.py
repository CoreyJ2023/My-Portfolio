'''
Programmer:     Corey Jenkins
Date:           February 8, 2023
Filename:       area_rectangle.py
Purpose:        To create a program that inputs the area of two rectangles
	            and determine if both are the same or not.
'''

def main():
    rectangles()
    
def rectangles():
    
    width1 = int(input("What is the width of the first rectangle?"))
    length1 = int(input("What is the length of the second rectangle?"))
    
    area_of_rectangle1 = length1 * width1
    
    width2 = int(input("What is the width of the second rectangle?"))
    length2 = int(input("What is the length of the second rectangle?"))
    
    area_of_rectangle2 = length2 * width2
    
    rectangle_compare(area_of_rectangle1, area_of_rectangle2)
    
def rectangle_compare(num1, num2):
    if(num1 == num2):
        print("Yes! The dimensions are the same.")
    else:
        print("No! The dimensions are not the same.")
main()