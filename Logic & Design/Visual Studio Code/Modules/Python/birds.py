'''
Programmer:		Corey Jenkins	
Date:			July 7, 2017 (Updated January 22, 2023)
Filename:		function_demo_2.py
Purpose:		An introduction to creating a module or function in Python
'''

# This program demonstrates two functions that
# have local variables with the same name.

def main():
	# Call the texas function.
	texas()
	# Call the california function.
	california()
	
# Definition of texas functiion. It also
# creates a local variable named birds.
def texas():
	birds = 5000
	print('texas has', birds, 'birds.')

# Definition of the california function. It also
# creates a local variable named birds.
def california():
	birds = 8000
	print('california has', birds, 'birds.')
	
# Call the main function.
main()