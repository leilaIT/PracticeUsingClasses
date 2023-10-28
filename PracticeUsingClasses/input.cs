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
            int uNum = 0;
            
            while(true)
            {
                Console.WriteLine("Please input a number between 0 and 65535");
                uNum = int.Parse(Console.ReadLine());
                if (uNum > 0 && uNum < 65535)
                    break;
                else
                {
                    Console.WriteLine("Invalid input. Press any key to try again.");
                    Console.ReadKey();
                }
                Console.Clear();
            }

            return uNum;
        }
    }
}
