namespace _01.Ext_Remove_Elements_at_Odd_Positions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var evenList = new List<string>();
 
            for (int i = 0; i < input.Count-1; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(input[i+1]);
                }
            }
 
            Console.WriteLine(string.Join("", evenList));
        }
    }
}