namespace _01.Count_Real_Num
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Dictionaries
    {
        public static void Main()
        {
            var realNumbersInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var counts = new SortedDictionary<double, int>(); // 8 2.5 2.5 8 2.5 key
                                                              // 0  0   0  0  0 value

            foreach (var num in realNumbersInput)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }

                counts[num]++;
            }

            foreach (var kvp in counts)
            {
                //string timeString = kvp.Value == 1 ? "time" : "times";

                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
