
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            int SophieJumps = 12;
            int TylerJumps = 9;
            int answer;
            Console.WriteLine("Sophie jumped on one foot 12 times in a row.");
            Console.WriteLine("Tyler jumped on one foot 9 times.");
            Console.WriteLine("How many more jumps did Sophie jump?");

            answer = SophieJumps - TylerJumps;

            Console.WriteLine("The answer is " + answer + ". But that's too easy! Let's kick it up a notch");
            CommonCore();
            Console.ReadKey();
        }

        static void CommonCore()
        {
            Console.WriteLine("For Common Core, we need to take 9 and break it to two number in which it can still be...");
            Console.WriteLine("...equal to the answer above. To do so 7 and 2 out of 9");
            Console.WriteLine("((12 -(7) - 2)");
            showNum(7, 2);

        }

        static void showNum(int num1, int num2)
        {
            int firstpart;
            int commonCoreAnswer;

            firstpart = 12 - num1;
            commonCoreAnswer = firstpart - num2;

            Console.WriteLine("The answer is " + commonCoreAnswer + ". Same answer but under a different logic.");

        }
    }   
}
