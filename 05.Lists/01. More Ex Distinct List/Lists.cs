namespace _01.More_Ex_Distinct_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();

            for (int index = 0; index < numbers.Count; index++)
            {
                for (int index2 = 1+index; index2 < numbers.Count; index2++)
                {
                    if (numbers[index] == numbers[index2])
                    {
                        numbers.RemoveAt(index2);
                        index2--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
