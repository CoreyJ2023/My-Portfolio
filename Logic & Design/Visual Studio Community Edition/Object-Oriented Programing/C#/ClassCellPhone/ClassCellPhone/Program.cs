/*
 * Programmer:          Corey Jeknins
 * Date:                April 18, 2021
 * Program name:        ClassCellPhone
 * Purpose:             A Demonstration of using Object Oriented Programming in C#
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCellPhone
{
    class CellPhone
    {
        private String manufacturer;
        private String modelNumber;
        private Double retailPrice;
        static void Main(string[] args)
        {
            CellPhone Phone = new CellPhone();
            Phone.manufacturer = "Motorolla";
            Phone.modelNumber = "M1000";
            Phone.retailPrice = 199.99;

            Console.WriteLine("The manufacutrer is " + Phone.manufacturer + ".");
            Console.WriteLine("The model number is " + Phone.modelNumber + ".");
            Console.WriteLine("The retail price is " + Phone.retailPrice + ".");

            Console.ReadKey();


        }
    }
}
