﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, set));
        }
    }
}
