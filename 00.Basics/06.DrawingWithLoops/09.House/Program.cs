﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;
            var starsHouse = n-2;
            if (n % 2 == 0) stars++;
            
            for (int i = 0; i < (n+1)/2; i++)
            {
            var padding = (n - stars) / 2;
            Console.Write(new string('-', padding));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', padding));
            stars = stars + 2;
            }

            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', starsHouse));
                Console.Write("|");
                Console.WriteLine();
            }
           
        }
    }
}
