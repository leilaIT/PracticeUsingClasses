using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class Program
    {
        //lecture notes:
        //pub and priv are used when a class is being called by another class
        //public - everything in class 2 will be accessible in class 1
        //private - everything in class 2 will not be visible in class 1

        //Create a program that would ask the user
        //for an input between 0 and 65535.
        //The program will then calculate the binary,
        //octal and hexadecimal counterpart for that number.
        //At minimum, your program should contain
        //at least two(2) classes in addition to Program.cs
        //Level 7: Display should always be: 
        // 16 binary
        // 6 octal 
        // 4 hexadecimal
        static void Main(string[] args)
        {
            //gets user input
            while(true)
            {
                int numToConvert = 0;
                input uNum = new input();
                numToConvert = uNum.inputNum();
                Console.Clear();

                //all conversions
                allConversion convert = new allConversion();
                convert.convertAll(numToConvert);

                //convert again
                repeat repeat = new repeat();
                if(!repeat.convertAgain())
                {
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine("Calculator is closing. Press any key to exit. . .");
            Console.ReadKey();
        }

        ////converts to binary
        //toBinary tb = new toBinary();
        //tb.convertBinary(numToConvert);
        //Console.WriteLine();

        ////converts to octal
        //toOctal to = new toOctal();
        //to.convertOctal(numToConvert);
        //Console.WriteLine();

        ////converts to hexadecimal
        //toHexadecimal th = new toHexadecimal();
        //th.convertHexadecimal(numToConvert);
    }
}
