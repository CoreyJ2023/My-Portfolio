'''
Programmer: 	Corey Jenkins
Date:			April 13, 2017 (Updated January 19, 2023)
Program Name:	temperature.py
Purpose:		This program assists a technician in the process of checking a substance's temperature
'''

# MAX_TEMP is used as a global constant for
# the maximum temperature.
MAX_TEMP = 102.5

# The main function
def main():
    temperature()
    
def temperature():
	# Get the substance's temperature.
	temperature = input("Enter the substance's Celsius temperature: ")
	
	# As long as necessary, instruct the user to 
	# adjust the thermostat.
	while temperature > MAX_TEMP:
		print('The temperature is too high.')
		print('turn the thermostat down a wait')
		print('5 minutes. Then take the temperature.')
		print('again and enter it.')
		temperature = input('Enter the Celsius temperature: ')
		
	# Remind the user to check the temperature again
	# in 15 minutes.
	print('The temperature is acceptable.')
	print('Check it again in 15 minutes.')

# Call the main function.
main()