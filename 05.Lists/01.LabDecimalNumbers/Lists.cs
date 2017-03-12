namespace _01.LabDecimalNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();
            numbers.ForEach(Console.WriteLine);
        }
    }
}
