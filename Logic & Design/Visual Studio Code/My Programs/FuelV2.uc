/* 
 *  Programmer:         Corey Jenkins
 *  Date:               March 25, 2024
 *  Filename:           FuelV2.uc
*/

class FuelV2 extends actor;

var string regular;
var string plus;
var string supreme;

var float regularPrice;
var float plusPrice;
var float supremePrice;

var int fuelSelect;

var int gallons;
var float total;

function PostBeginPlay()
{
    regular = "Regular";
    plus = "Plus";
    supreme = "Supreme";

    regularPrice = 3.99;
    plusPrice = 4.99;
    supremePrice = 5.99;

    fuelSelect = 1; // This will select case 1.

    switch (fuelSelect)
    {
        case 1:
        `log("This has been selected: " @ regular);
        total = regularPrice * gallons;
        `log("Thank you! This is your receipt: " @ total);
    
        // With fuelSelect being set to 1, the following two will be disregarded in this example.
        case 2:
        `log("This has been selected: " @ plus);
        total = plusPrice * gallons;
        `log("Thank you! This is your receipt: " @ total);
    
        case 3:
        `log("This has been selected: " @ supreme);
        total = supremePrice * gallons;
        `log("Thank you! This is your receipt: " @ total);
    }
}
