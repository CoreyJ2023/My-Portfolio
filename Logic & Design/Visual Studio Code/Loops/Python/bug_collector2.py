'''
Programmer:         Corey Jenkins
Date:               February 4, 2023
Filename:           bug_collector2.py
Purpose:            To create a program using a module, that runs a loop of seven days and putting in how many bugs you've collected a day.
'''

def main():
    # Function total_bugs
    total_bugs()
    
def total_bugs():
    # Set the integer total to 0
    total = 0
    
    # Integer days. To collect bugs up to seven days in a for loop.
    # The difference between this program and the program bug_collector.py is that the total is calculated every day in the loop.
    for days in range(1, 8): # To loop day 1 through seven
        
        bugs = int(input("Bug(s) collected:"))
        total = (total + bugs)
        print("Bug(s) collected on day",days,":",bugs)
        print("Total bug(s) collected:",total)
        
    print("The total amount collected in seven days:",total,".")
    
main()