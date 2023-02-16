'''
Programmer:         Corey Jenkins
Date:               February 4, 2023
Filename:           distance_traveled.py
Purpose:            Purpose: to create a program using a module,
                    that calculates the distance of a vehicle using this formula: Distance = Speed * Time
'''
# Global variable set.
MAX_VALUE = 3

def main():
    final_results()
    
def final_results():
    # Input for speed and hours.
    speed = int(input("What is the speed of the vehicle in MPH:"))
    
    hour = int(input("And how many hours has it traveled: "))
    
    print("Hour\tDistance traveled")
    print("------------------------")
    for hour in range(MAX_VALUE):
        distance = (speed * hour)
        print(speed,"\t\t",distance)
main()
