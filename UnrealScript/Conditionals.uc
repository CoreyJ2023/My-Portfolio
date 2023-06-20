/*
Programmer:             Crim
Date:                   August 16, 2022
Program Name:           AwesomeActorIfElse.uc
Purpose:                A demonstration of If/Else in UnrealScript.
*/

Class Conditionals extends Actor
placeable;

var int NumberOne;
var int NumberTwo;

function PostBeginPlay()
{
    NumberOne = 2;
    NumberTwo = 5;
    if(NumberOne < NumberTwo)
        `log("Two is less than five!");
        `log("This should be correct!");
}

Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
