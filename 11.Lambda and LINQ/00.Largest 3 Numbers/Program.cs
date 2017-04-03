namespace _00.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var largestNumbers = numbers.OrderByDescending(n => n).Take(3);

            Console.WriteLine(string.Join(" ",largestNumbers));
        }
    }
}
