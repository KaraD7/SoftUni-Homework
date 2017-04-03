namespace _00.MinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int []nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
                //var sum = nums.Sum();
                //var min = nums.Min();
                //var max = nums.Max();
                //var average = nums.Average();

                //Console.WriteLine("Sum = {0}", sum);
                //Console.WriteLine("Min = {0}", min);
                //Console.WriteLine("Max = {0}", max);
                //Console.WriteLine("Average = {0}", average);

            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Average = {0}", nums.Average());
        }
    }
}
