'''
Programmer:     Corey Jenkins
Date:           January 24, 2023
Filename:       algorithm1.py
Purpose:        An algorithm that is an event-driven program.
'''

def main():
    menu()
    
def menu():
    print("This is the main menu.")
    print("1. Open a menu.")
    print("2. Close the current document.")
    print("3. Print the current document.")
    print('4. Exit the program.')
    menu_selection = int(input("Enter your selection: "))
    
   # Python does not have case/switch; therefore, if/else statements must be used.
    
    if (menu_selection == 1):
        print("Opening the menu.")
    elif (menu_selection == 2):
        print('Closing the document.')
    elif (menu_selection == 3):
        print("Printing the document.")
    elif (menu_selection == 4): 
        print("Exiting the program.")
    else:
        print("You have made an invalid seleciton.")
menu()
        