using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class toOctal
    {
        private Stack<string> bits = new Stack<string>();
        private int dispCount = 0;
        private int remainder = 0;
        public void convertOctal(int numToConvert)
        {
            Console.Write(numToConvert + " in octal is ");

            while (numToConvert > 0)
            {
                remainder = numToConvert % 8;
                bits.Push(remainder + "");

                numToConvert = numToConvert / 8;
            }

            while (bits.Count != 6)
                bits.Push("0");

            while (bits.Count() > 0)
            {
                Console.Write(bits.Pop());
                dispCount++;

                if (dispCount == 3)
                {
                    Console.Write(" ");
                    dispCount = 0;
                }
            }
        }
    }
}
