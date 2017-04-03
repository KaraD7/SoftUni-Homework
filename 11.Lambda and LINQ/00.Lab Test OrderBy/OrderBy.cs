
namespace _00.Lab_Test_OrderBy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class OrderBy
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1, 6, 3, 0, 5, 2, 7, 8, 9, 4
            };

            var sortedNumbers = numbers
                .OrderBy(num => num)  // or OrderByDescending () <-- into Reverse Order
                .ToList();
            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}
