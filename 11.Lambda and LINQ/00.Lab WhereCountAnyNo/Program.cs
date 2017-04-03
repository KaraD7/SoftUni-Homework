namespace _00.Lab_WhereCountAnyNo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1,2,3,4,5,6,7,8,9, 5, 5, 3
            };

            var sortedNumbersWhere = numbers.Where(n => n % 3 == 0);
            Console.WriteLine(string.Join(", ",sortedNumbersWhere));

            var sortedNumbersCount = numbers.Count(n => n > 5);
            Console.WriteLine(string.Join(", ", sortedNumbersCount));

            var hasNumber = numbers.Any(n => n > 5);// bool type
            if (hasNumber)
            {
                Console.WriteLine("Yes, there are numbers Any fucntion!");
            }

            var hasNumbersAllFunc = numbers.All(n => n > 5);
            if (hasNumbersAllFunc)
            {
                Console.WriteLine("Yes, numbers with All function");
            }
            else
            {
                Console.WriteLine("No, numbers with all function");
            }

            // Select Method,     from string to int, double....

            var numberSelect = numbers.Select(n => n * 2).ToList();
            Console.WriteLine(string.Join("   ", numberSelect));
            var symbols = numbers.Select(n => "Number: " + n);
            Console.WriteLine(string.Join(Environment.NewLine, symbols));

            // distinct method

            var distinctNumbers = numbers.Distinct().ToArray();
            Console.WriteLine(string.Join(" distinct,", distinctNumbers));
        }
    }
}
