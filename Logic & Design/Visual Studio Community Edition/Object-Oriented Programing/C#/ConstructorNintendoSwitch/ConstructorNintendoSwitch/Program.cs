using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorNintendoSwitch
{
    class Program
    {
        string consoleName;
        string colors;
        double retailPrice;
        static void Main(string[] args)
        {
            Program Nintendo = new Program();

            Nintendo.consoleName = "Nintendo Switch";
            Nintendo.colors = "Black";
            Nintendo.retailPrice = 199.99;

            Console.WriteLine(Nintendo.consoleName);
            Console.WriteLine(Nintendo.colors);
            Console.WriteLine(Nintendo.retailPrice);

            Console.ReadKey();
        }
    }
}
