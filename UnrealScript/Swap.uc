/*
Programmer:             Corey Jenkins
Date:                   April 29, 2023
FileName:               Swap
Purpose:                A test to see if swapping without a Temporary Variable possible in UnrealScript
*/

Class Swap extends Actor
placeable;

var int x;
var int y;
var int temp;

function PostBeginPlay()
{
    x = 3;
    y = 4;
    `log("X is :" @ x);
    `log("Y is :" @ y);

    temp = x; // Temporary Variable.
    x = y; // Swap.
    y = temp;

    `log("X is now: " @ x);
    `log("Y is now: " @ y);
}

defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}

