using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class toHexadecimal
    {
        private Stack<string> bits = new Stack<string>();
        private int dispCount = 0;
        private int remainder = 0;
        public void convertHexadecimal(int numToConvert)
        {
            Console.Write(numToConvert + " in hexadecimal is ");

            while (numToConvert > 0)
            {
                remainder = numToConvert % 16;
                if(remainder == 10)
                    bits.Push("A");
                else if (remainder == 11)
                    bits.Push("B");
                else if (remainder == 12)
                    bits.Push("C");
                else if (remainder == 13)
                    bits.Push("D");
                else if (remainder == 11)
                    bits.Push("E");
                else if (remainder == 15)
                    bits.Push("F");
                else
                    bits.Push(remainder + "");

                numToConvert = numToConvert / 16;
            }

            while (bits.Count != 4)
                bits.Push("0");

            while (bits.Count() > 0)
                Console.Write(bits.Pop());
        }
    }
}
