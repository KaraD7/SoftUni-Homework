namespace _00.Array_Contains_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArraysLists
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var searchedNumber = int.Parse(Console.ReadLine());

            /*bool isFound = false;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
               
                if (arrayOfNumbers[i] == searchedNumber)
                {
                    isFound = true;
                    break;
                }
                
            }
            if (isFound)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            */
            // OR
            
            bool found = arrayOfNumbers.Contains(searchedNumber);

            if(found)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
             
        }
    }
}
