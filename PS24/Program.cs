﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
                Console.Read();
               
                
            
            Console.Read();
        }
    }
}
