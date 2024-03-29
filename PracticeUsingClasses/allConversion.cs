﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUsingClasses
{
    internal class allConversion
    {
        private Stack<string> bits = new Stack<string>();
        private int dispCount = 0;
        private int remainder = 0;
        private int baseNum = 0;
        private int convertCount = 0;
        private int bitCount = 0;
        private int disp = 0;
        public void convertAll(int numToConvert)
        {
            while (convertCount < 3)
            {
                //assigning of variables
                switch (convertCount)
                {
                    case 0: //binary
                        Console.Write(numToConvert + " in binary is ");
                        baseNum = 2;
                        bitCount = 16;
                        disp = 4;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case 1: //octal
                        Console.Write(numToConvert + " in octal is ");
                        baseNum = 8;
                        bitCount = 6;
                        disp = 3;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 2: //hexa
                        Console.Write(numToConvert + " in hexadecimal is ");
                        baseNum = 16;
                        bitCount = 4;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                //conversion
                conversion(numToConvert);

                //display
                displayBits();

                convertCount++;
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        private Stack<string> conversion (int numToConvert)
        {
            while (numToConvert > 0)
            {
                remainder = numToConvert % baseNum;
                switch (convertCount)
                {
                    case 0:
                        if (numToConvert % 2 == 1)
                        {
                            bits.Push("1");
                            numToConvert--;
                        }
                        else
                            bits.Push("0");
                        break;
                    case 1:
                        bits.Push(remainder + "");
                        break;
                    case 2:
                        if (remainder == 10)
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
                        break;
                }

                numToConvert = numToConvert / baseNum;
            }
            return bits;
        }
        private void displayBits()
        {
            while (bits.Count != bitCount)
                bits.Push("0");

            while (bits.Count() > 0)
            {
                Console.Write(bits.Pop());

                if (convertCount != 2)
                {
                    dispCount++;
                    if (dispCount == disp)
                    {
                        Console.Write(" ");
                        dispCount = 0;
                    }
                }
            }
        }
    }
}
