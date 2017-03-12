namespace _00.LabCountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine() // 8 2 2 8 2 2 3 7
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            if (numbers.Count > 0)
            {
                numbers.Sort();  // 2 2 2 2 3 7 8 8
                numbers.Add(int.MaxValue);
                var previous = numbers[0];
                var count = 1;

                for (int i = 0; i < numbers.Count; i++)
                {
                    var currentNumber = numbers[i];
                    if (currentNumber==previous)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previous} - {count}");
                        count = 1;
                    }
                    previous = currentNumber;
                }

            }
            
        }
    }
}
