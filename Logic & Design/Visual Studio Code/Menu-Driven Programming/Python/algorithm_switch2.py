'''
Programmer:     Corey Jenkins
Date:           December 13, 2024
Filename:       algorithm_switch2.py
Purpose:        Using an input validation with the case/switch in Python. Introduced in version 3.XX
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
    
    # Input validation.
    while(menu_selection < 1 or menu_selection > 4):
        print("You have made an invalid seleciton.")
        menu_selection = int(input("Please enter 1, 2, 3 or 4: "))
        
    
    match menu_selection:
        case 1:
            print("Opening the menu.")
        case 2:
            print("Closing the document.")
        case 3:
            print("Printing the document.")
        case 4:
            print("Exiting the program.")

menu()
        