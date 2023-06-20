/*
*   Programmer:         Corey Jenkins
*   Date:               June 19, 2023
*   Filename:           CommonCore.uc
*   Purposes:           A script that shows how to solve using the tradtional way and through Common Core
*/

Class CommonCore extends Actor
placeable; // to be placed in the editor as a marker to walk over

var int MysteryNumber1;
var int MysteryNumber2;
var int step1;
var int step2;
var int CommonCoreSolution;
var int SetRandomNumber;

function PostBeginPlay()
{
    Super.PostBeginPlay();
    MysteryNumber1 = Rand(10);
    `log(MysteryNumber1);

}

defaultproperties
{
    Begin Object Class=SpriteComponent Name=Sprite
    Sprite=Texture2D'EditorResources.S_Navp'
    End Object
    Components.Add(Sprite)
}