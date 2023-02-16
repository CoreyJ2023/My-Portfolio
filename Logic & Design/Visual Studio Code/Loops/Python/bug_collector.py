'''
Programmer:         Corey Jenkins
Date:               February 4, 2023
Filename:           bug_collector.py
Purpose:            to create a program using a module, that runs a loop of seven days and putting in how many bugs you've collected a day.
'''

def main():
    # Function total_bugs
    total_bugs()
    
def total_bugs():
    # Set the integer total to 0
    total = 0
    
    # Integer days. To collect bugs up to seven days in a for loop.
    for days in range(7):
        
        bugs = int(input("Bug(s) collected:"))
        total = (total + bugs)
        
    print("The amount collected in seven days:",total,".")
    
main()