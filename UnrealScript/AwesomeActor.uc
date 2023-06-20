/*
Programmer:             Corey Jenkins
Date:                   August 13, 2022
Program Name:           AwesomeActor.uc
Purpose:                A demonstration of using UnrealScript.
*/

Class AwesomeActor extends Actor // The child is AwesomeActor and it extends to the parent Actor.
placeable; // This allows to make it placable on the map.

function PostBeginPlay()
{
    `Log("Hello World.");
}

Defaultproperties
{   
    /* This calls for a texture or an object to be assigned to AwesomeActor and will be visbially
    shown on the map to place */
    
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
