/*
* Programmer:           Corey Jenkins
* Date:                 May 16, 2023
* Filename:             ChildHeritage.uc
* Purpose:              A demonstration of inheritance 
*/

Class ChildHeritage extends ParentHeritage;

var() string GrandChild;

function PostBeginPlay()
{
    son = "Marcus Fenix";
    
    `log("His name is "@ son);
    
}

defaultproperties
{

}
