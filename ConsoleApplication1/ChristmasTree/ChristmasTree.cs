﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.ChristmasTree
{
    class ChristmasTree
    {
        static void Main()
        {
            int spaces = 10;
            int asterix = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
            }
            Console.ReadLine();
        }
    }
}
