using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class repeat
    {
        public bool convertAgain()
        {
            bool ask = true;
            string inp = "";

            Console.WriteLine("\nWould you like to convert a different number?");
            inp = Console.ReadLine().ToUpper();
            switch(inp)
            {
                case "N":
                    ask = false;
                    break;
                default:
                    break;
            }
            return ask;
        }
    }
}
