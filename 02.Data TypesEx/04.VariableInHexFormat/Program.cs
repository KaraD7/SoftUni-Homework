﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(first, 16));
        }
    }
}
