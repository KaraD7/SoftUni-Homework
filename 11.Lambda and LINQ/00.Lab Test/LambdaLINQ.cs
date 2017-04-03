namespace _00.Lab_Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LambdaLINQ
    {
        public static void Main()
        {
            var numbers = new List<int>
            {
                1,2,3,4,5,6,7,8,9
            };

            var sum = numbers.Sum();
            Console.WriteLine(sum);

            var min = numbers.Min();
            Console.WriteLine(min);

            var max = numbers.Max();
            Console.WriteLine(max);

            var average = numbers.Average();
            Console.WriteLine(average);
        }
    }
}
