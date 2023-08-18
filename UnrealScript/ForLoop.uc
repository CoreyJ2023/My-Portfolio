/*
Programmer:             Corey Jenkins
Date:                   August 16, 2022
Program Name:           ForLoop.uc
Purpose:                A demonstration of For loops in UnrealScript.
*/

Class ForLoop extends Actor
placeable;

// Are these supposed to be global variables?
var int steps;
var int index;

function PostBeginPlay()
{
    steps = 3;
    index = 0;
    for(index = 0; index < steps; index++)
    {
        `log("This should be displayed three times.");
    }
    `log("Excellent!");

}

Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
