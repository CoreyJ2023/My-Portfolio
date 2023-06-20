/*
Programmer:             Crim
Date:                   August 16, 2022
Program Name:           AwesomeActorBool.uc
Purpose:                A demonstration of the boolean function.
*/

Class Bool extends Actor
placeable;

var bool bIsItRaining; // The b is used to indicated that this variable is a boolean.

function PostBeginPlay()
{
    bIsItRaining = true;
    `log("Is it raining?" @ bIsItRaining); // This will read as true in the log.
    bIsItRaining = false;
    `log("Is it raining?" @ bIsItRaining); // This will read as false in the log.
}

Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
