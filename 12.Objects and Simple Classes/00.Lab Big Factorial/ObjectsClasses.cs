﻿namespace _00.Lab_Big_Factorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    public class ObjectsClasses
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
