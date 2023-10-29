using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class input
    {
        /// <summary>
        /// gets num from user
        /// </summary>
        /// <returns> valid number </returns>
        public int inputNum ()
        {
            string uNum = "";
            bool notValid = false;
            int num = 0;
            
            while(true)
            {
                Console.WriteLine("Please input a number between 0 and 65535");
                uNum = Console.ReadLine();
                if(int.TryParse(uNum, out num))
                {
                    if (num > 0 && num < 65535)
                        break;
                }
                if(!notValid)
                {
                    Console.WriteLine("Invalid input. Press any key to try again.");
                    Console.ReadKey();
                }
                Console.Clear();
            }

            return num;
        }
    }
}
