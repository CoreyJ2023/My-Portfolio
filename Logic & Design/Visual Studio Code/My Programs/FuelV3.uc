/*
 *  Programmer:     Corey Jenkins
 *  Date:           March 25, 2024
 *  Filename:       FuelV3.uc
 *  Purpose:        Using structs and while loops to create a program that calculates how it cost to fuel
 *                   up a vehicle by fuel grade and gallon(s) entered.
*/

class FuelV3 extends Actor;

struct Fuel
{
    var string regular;
    var string plus;
    var string supreme;

    var float regularPrice;
    var float plusPrice;
    var float supremePrice;
};

var Fuel myFuel;
var int total;
var int gallons;
var int fuelSelect;

// Declare Module main().
function PostBeginPlay()
{
    myFuel.regular = "Regular";
    myFuel.plus = "Plus";
    myFuel.supreme = "Supreme";

    myFuel.regularPrice = 3.99;
    myfuel.plusPrice = 4.99;
    myFuel.supremePrice = 5.99;

    `log("Selecting Option 2 for fuelSelect: Plus.")
    fuelSelect = 2;

    switch (fuelSelect)
    {
        case 1:
            `log("You have selected: " @ myFuel.regular @ ".");
            gallons = 10;
            total = gallons * myFuel.regularPrice;
            `log("Thank you. Here is your total:" @ total);
            break;

        case 2: // This is selected!!
            `log("You have selected: " @ myFuel.plus @ ".");
            gallons = 20;
            total = gallons * myFuel.plusPrice;
            `log("Thank you. Here is your total:" @ total); // 20 * 4.99
            break;

        case 3:
            `log("You have selected: " @ myFuel.supreme @ ".");
            gallons = 10;
            total = gallons * myFuel.supremePrice;
            `log("Thank you. Here is your total:" @ total);
            break;
    }
    
}

defaultproperties
{
    
}