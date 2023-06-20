/*
Programmer:             Corey Jenkins
Date:                   August 16, 2022
Program Name:           Mathemetics.uc
Purpose:                A demonstration of mathematics using UnrealScript
*/

Class Mathematics extends Actor
placeable;

var int FirstNumber;
var int SecondNumber;
var int ThirdNumber;
var int Answer;


function PostBeginPlay()
{
     FirstNumber = 1;
     SecondNumber = 3;
     ThirdNumber = 5;
     Answer = (FirstNumber + SecondNumber * ThirdNumber);
     `log("The answer is: " @ Answer);

}

Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
