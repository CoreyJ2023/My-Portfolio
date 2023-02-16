'''
Programmer:	 Corey Jenkins	
Date:		 July 7, 2017 (Updated January 22, 2023)
Filename: 	 pass_args.py
Purpose: 	 Pass by arguments.
'''

# Define the main function
def main():
	number = input('Enter a number and I will display that number doubled: ')
	double_number(number)
	
# Define the doube_number function.
def double_number(value):
	result = value * 2
	print(result)
	
# Call the main function.
main()