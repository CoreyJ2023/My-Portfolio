/*
Programmer:             Corey Jenkins
Date:                   August 16, 2022
Program Name:           IntegersFloats.uc
Purpose:                A demonstration of integers and floats in UnrealScript.
*/

Class IntegersFloats extends Actor
placeable;

var int NumberOfKittens; // Create an integer variable and name it NumberOfKittens.
var float DistanceToGo; // This creates a float variable.

function PostBeginPlay()
{
    NumberOfKittens = 5;
    `log("Number of kittens:" @ NumberofKittens); // This should be set to 5.
    DistanceToGo = 1.5;
    `log("Distance to go:" @ DistanceToGo); // This should be set to 1.5(00).
}

Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
