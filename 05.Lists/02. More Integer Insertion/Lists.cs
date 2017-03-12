namespace _02.More_Integer_Insertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var lineNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //var rowNumbers = new List <string>();
            //var rowNumbers = new List<string>{ "25", "716", "2772", "1982", "8534", "2" };
            var rowNumbers = new List<int> {25, 716, 2772, 1982, 8534, 2 };


            //var numbers = Console.ReadLine();

            /*while (numbers != "end")
            {
                var isNumber = false;

                if (!isNumber)
                {
                    rowNumbers.Add(numbers);
                }

                numbers = Console.ReadLine();
            }*/


            for (int index = 0; index < rowNumbers.Count; index++)
            {

                //char firstDigit = rowNumbers[index].ToString()[0]; // get first digit example: 3256 = 3
                //int firstDigit1 = rowNumbers[index].ToString().Substring(0, 1);
                var firstDigit1 = rowNumbers[index];
                var result = Math.Floor(firstDigit1 / Math.Pow(10, Math.Floor(Math.Log10(firstDigit1))));

                lineNumbers.Insert(firstDigit1, rowNumbers[index]);
            }


            foreach (var result in rowNumbers)
            {
                Console.WriteLine(result);
            }
        }
    }
}
