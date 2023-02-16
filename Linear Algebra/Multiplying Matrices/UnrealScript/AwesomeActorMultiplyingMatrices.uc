/*
Programmer:             Corey Jenkins
Date:                   August 31, 2022 (Updated January 3, 2023)
Program Name:           AwesomeActorMultiplyingMatrices
Purpose:                A demonstration of multiplying matrices using UnrealScript.
                        This program can only be run on UDK or Unreal Development Kit.
*/

Class AwesomeActorMultiplyingMatrices extends Actor
placeable;

var int PointX, PointY, PointZ;

function PostBeginPlay()
{
    /* These variables will give the product for the coordinates on the X, Y, and Z axis.
        [(2 -1 0), (3 2 -1), (-3, 1, 2)] and [(1,4,3)] Multiply then add. Dot Product.
    */
    PointX = (2 * 1) + (-1 * 4) + (0 * 3);
    PointY = (3 * 1) + (2 * 4) + (-1 * 3);
    PointZ = (-3 * 1) + (1 * 4) + (2 * 3);
    `log("The Solution is:[" $ PointX $ "," $ PointY $ "," $ PointZ $ "]");
}

Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
