/*
* Programmer:           Corey Jenkins
* Date:                 May 16, 2023
* Filename:             AwesomeGrandChild.uc
* Purpose:              A demonstration of inheritance
*/

Class GrandChildHeritage extends ChildHeritage
placeable;

function PostBeginPlay()
{
    GrandChild = "James Dominick Fenix";

    `log("His name is "@ GrandChild);
}

defaultproperties
{
}