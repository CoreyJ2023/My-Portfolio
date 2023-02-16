/*
 * Programmer:      Corey Jenkins
 * Filename:        StructFunction.cs
 * Date:            September 27, 2022
 * Purpose:         The use of an enumerator and structs to assign each cow's name, age and purpose.
*/
using System;

namespace StructFunction
{
    class StructFunction
    {
        enum CowType
        {
            dairy,
            hide,
            pet
        }
        struct cow
        {
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            
            cow1();
            cow2();
            cow3();
            Console.ReadKey();
        }

        static void cow1()
        {
            cow MyCow1;
            MyCow1.name = "Betty";
            MyCow1.age = 5;
            CowType myCow = CowType.dairy;

            Console.WriteLine("This cow's name is " + MyCow1.name + ".");
            Console.WriteLine(MyCow1.name + " is " + MyCow1.age + "Years old.");
            Console.WriteLine(MyCow1.name + " is a cow for " + myCow + ".");
        }

        static void cow2()
        {
            cow MyCow1;
            MyCow1.name = "Abigail";
            MyCow1.age = 7;
            CowType myCow = CowType.hide;

            Console.WriteLine("This cow's name is " + MyCow1.name + ".");
            Console.WriteLine(MyCow1.name + "is " + MyCow1.age + " Years old.");
            Console.WriteLine(MyCow1.name + " is a cow for " + myCow + ".");

        }

        static void cow3()
        {
            cow MyCow1;
            MyCow1.name = "The Cow King";
            MyCow1.age = 9;
            CowType myCow = CowType.pet;

            Console.WriteLine("This cow's name is " + MyCow1.name + ".");
            Console.WriteLine(MyCow1.name + " is " + MyCow1.age + " Years old.");
            Console.WriteLine(MyCow1.name + " is a cow for a " + myCow + ".");
        }
    }
}
