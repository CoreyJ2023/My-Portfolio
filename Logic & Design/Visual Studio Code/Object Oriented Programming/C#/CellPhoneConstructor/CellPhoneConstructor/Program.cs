/*
* Programmer:       Corey Jenkins  
* Date:             February 29, 2024
* Filename:         CellPhoneConstructor.cs
* Purpose:          Object-Oriented Programming with Constructors... in C#
*/

using System;
using System.Runtime.CompilerServices;

namespace CellPhoneConstructor
{
    class CellPhoneConstructor
    { 
        private string manufacturer;
        private string modelNumber;
        private double retailPrice;

        public CellPhoneConstructor(string manufact, string model, double retail)
        {
            manufacturer = manufact;
            modelNumber = model;
            retailPrice = retail;
        }

        public void setManufacturer(string manufact)
        {
            manufacturer = manufact; 
        }
        
        public void setModelNumber(string model)
        {
            modelNumber = model;
        }

        public void setRetailPrice(double retail)
        {
            retailPrice = retail;
        }

        public string getManufacturer()
        {
            return manufacturer;
        }

        public string getModelNumber()
        {
            return modelNumber;
        }

        public double getRetailPrice()
        {
            return retailPrice;
        }

        static void Main(string[] args)
        {
            CellPhoneConstructor myPhone;
            myPhone = new CellPhoneConstructor("Motorolla", "M1000", 199.99);

            Console.WriteLine("The manufacturer is:" + myPhone.getManufacturer());
            Console.WriteLine("The model number is:" + myPhone.getModelNumber());
            Console.WriteLine("The retail price is:" + myPhone.getRetailPrice());
        }

    }
}
