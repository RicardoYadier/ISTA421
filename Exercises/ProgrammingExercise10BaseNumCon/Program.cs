﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaseNumConv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the integer to convert: ");
            string n1 = Console.ReadLine();
            int number = int.Parse(n1);
            Console.Write("Please enter the base to convert from: ");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);

            Console.WriteLine($"Number: {number}, base:{from}");
            int result = 0;
            if (from == 10)
            {
                result = Util.dec2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = Util.dec2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 2)
            {
                result = Util.bin2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
                result = Util.bin2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 8)
            {
                result = Util.oct2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = Util.oct2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
            }
            else
                Console.WriteLine("Error in base to convert from");
        }
    }

}
