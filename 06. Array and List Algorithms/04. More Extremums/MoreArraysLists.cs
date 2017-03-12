namespace _04.More_Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MoreArraysLists
    {
        public static void Main()
        {

            var test = new List<char>();
            test[0] = '1';
            test[1] = '2';
            test[2] = '3';

            Console.WriteLine(string.Join(" ", test));

            // text file
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string sumOfNumbers = Console.ReadLine();

            for (int indexOfnumber = 0; indexOfnumber < numbers.Length; indexOfnumber++) // 100
            {
                var arrayOfFirstNumber = numbers[indexOfnumber];
                var arrayO = new int[arrayOfFirstNumber];
                

                for (int indexOfDigit = 0; indexOfDigit < Length; indexOfDigit++) 
                {

                }
            }

            if (sumOfNumbers == "Max")
            {
                
            }
            if (sumOfNumbers == "Min")
            {

            }
        }
    }
}
