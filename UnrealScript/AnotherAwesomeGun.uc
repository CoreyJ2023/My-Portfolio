/*
*   Programmer:     Corey Jenkins
*   Date:           May 18, 2023
*   Filename:       AnotherAwesomeGun.uc
*   Purpose:        Using inheritance to take values from the parent to the child.
*/

Class AnotherAwesomeGun extends AwesomeWeapon;

var int MyInt;

defaultproperties
{
    ShotCost = 5.5
    Range = 2.2
}
