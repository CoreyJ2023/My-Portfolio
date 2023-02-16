using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSelect
{
    class LanguageMenu
    {
        static void Main(string[] args)
        {
            int language;
            Console.WriteLine("Please select a language: ");
            Console.WriteLine("1 - English");
            Console.WriteLine("2 - Kouri-Vini");
            Console.WriteLine("3 - Français");
            language = Convert.ToInt32(Console.ReadLine());

            while (language < 1 || language > 3)
            {
                Console.WriteLine("An error has occured.");
                Console.WriteLine("Please select a language: ");
                Console.WriteLine("1 - English");
                Console.WriteLine("2 - Kouri-Vini");
                Console.WriteLine("3 - Français");
                language = Convert.ToInt32(Console.ReadLine());
            }

            switch(language)
            {
                case 1:
                    Console.WriteLine("You have selected English!");
                    break;

                case 2:
                    Console.Write("To té shwazí langaj kouri-vini! ");
                    Console.Write("Kouri-vini çé langaj endanjere dan Lalwizyann! ");
                    Console.Write("Mo gran-granpær té parlé kouri-vini é\n");
                    Console.WriteLine("m'apé aprenn langaj-çila! ");
                    Console.WriteLine("Mo pli myé en kréyòl ke françé");
                    break;

                case 3:
                    Console.Write("C'est français. Bonjour!");
                    Console.WriteLine("Je suis mellieur en le créole louisianas que français (Standard et français louisianias.)");
                    break;
            }

            Console.ReadKey();

        }
    }
}
