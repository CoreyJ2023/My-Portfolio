'''
Programmer:		Corey Jenkins
Date:			April 6, 2017 (Updated January 19, 2023)
Program Name:	payroll.py
Purpose:		Creating a input validation program for payroll.
'''
# Input the function or module here.
def main():
	showResults()
	
# The function or module starts here
def showResults():
	hours = int(input('Enter the hours worked: '))
 
	# The while loop, a conditional will prevent any negative number or
	# numbers over 40 for being inputted. If so, this while loop will occur.
	while hours < 0 or hours > 40:
		print('Sorry. You must enter hours between 0 and 40. Please enter the hours again. ')
		hours = input('Enter the hours worked: ')

	hourly_pay = float(input('What is the pay per hour: '))
	
 	# This also applies with the while loop for "hours" but this time
	# for the variable "hourlyPay"
	while hourly_pay < 7.50 or hourly_pay > 18.25:
		print('Enter a wage between 7.50 and 18.25. Try again.')
		hourly_pay = float(input('What is the pay per hour: '))

	total_pay = hours * hourly_pay
	# This will give us the results
	print('The total amount is $%.2f' % total_pay,".")

main()