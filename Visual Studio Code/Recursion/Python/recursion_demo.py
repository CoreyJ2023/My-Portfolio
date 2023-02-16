'''
Programmer:     Corey Jenkins
Date:           January 27, 2022
Program Name:   recursion_demo.py
Purpose:        A demonstration on using a recursion in Python.
'''

def main():
    # We are passing the argument 5 to the message module.
    # We are telling it to display it five times.
    message(5)
    
def message(times):
    if(times > 0):
        print("This is a recursive modules.")
        message(times - 1)
main()