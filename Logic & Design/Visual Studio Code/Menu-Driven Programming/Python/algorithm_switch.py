'''
Programmer:     Corey Jenkins
Date:           December 13, 2024
Filename:       algorithm_switch.py
Purpose:        Creating a menu using the case/switch. New for Python 3.xx.
'''
def main():
    menu()

def menu():
    print("This is the main menu.")
    print("1. Open a menu")
    print("2. Close the current document.")
    print("3. Print the current document")
    print("4. Exit the program.")

    menu_selection = int(input("Enter your selection: "))

    match menu_selection:
        case 1:
            print("Opening the menu.")
        case 2:
              print("Closing the document")
        case 3:
            print("Printing the document.")
        case 4:
            print("Exiting the program.")
        case _:
            print("You have made an invalid selection.")
            
menu()