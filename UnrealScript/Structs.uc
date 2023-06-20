/*
Programmer:             Corey Jenkins
Date:                   September 24, 2022
Program Name:           Structs.uc
Purpose:                A demonstration of using Structs using UnrealScript.
*/

Class Structs extends Actor
placeable;

struct cow
{
    var string name;
    var int age;
};

var cow MyCow;

function PostBeginPlay()
{
    MyCow.name = "Betsy";
    MyCow.age = 7;
    `log("The cow's name is " @ MyCow.name);
    `log(MyCow.name $ " is " @ MyCow.age @ " years old.");

}
Defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}
