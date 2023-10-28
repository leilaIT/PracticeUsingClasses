using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class toBinary
    {
        private Stack<int> bits = new Stack<int>();
        private int dispCount = 0;
        public void convertBinary(int numToConvert)
        {
            Console.Write(numToConvert + " in binary is ");

            while (numToConvert > 0)
            {
                if (numToConvert % 2 == 1)
                {
                    bits.Push(1);
                    numToConvert--;
                }
                else
                    bits.Push(0);

                numToConvert = numToConvert / 2;
            }

            while (bits.Count != 16)
                bits.Push(0);

            while (bits.Count() > 0)
            {
                Console.Write(bits.Pop());
                dispCount++;

                if (dispCount == 4)
                {
                    Console.Write(" ");
                    dispCount = 0;
                }
            }
        }
    }
}
