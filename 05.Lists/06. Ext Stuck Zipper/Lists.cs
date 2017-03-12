namespace _06.Ext_Stuck_Zipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList(); //select from str to int
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var idealNumberOfDigit = CalculateIdealNumberOfDigits(list1, list2);

            RemoveElementsWithNonIdealNumberFromList(list1,idealNumberOfDigit);
            RemoveElementsWithNonIdealNumberFromList(list2,idealNumberOfDigit);

            var insertionIndex = 1;
            for (int i = 0; i < list1.Count; i++)
            {
                var currentElement = list1[i];
                list2.Insert(Math.Min (insertionIndex, list2.Count), currentElement);
                insertionIndex += 2;
            }

            Console.WriteLine(string.Join(" ", list2));

        }

        public static void RemoveElementsWithNonIdealNumberFromList(List<int> list, int idealNumberOfDigit)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var currentElement = list[i];
                var currentNumberOfDigits = CalculateNumberOfDigit(currentElement);

                if (currentNumberOfDigits > idealNumberOfDigit)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        public static int CalculateIdealNumberOfDigits(List<int> list1, List<int> list2)
        {
            var idealNumberOfDigit = int.MaxValue;

            foreach (var item in list1) //first list
            {
                var numberOfDigit = CalculateNumberOfDigit(item);

                if (numberOfDigit < idealNumberOfDigit)
                {
                    idealNumberOfDigit = numberOfDigit;
                }
            }

            foreach (var item in list2) // second list
            {
                var numberOfDigit = CalculateNumberOfDigit(item);

                if (numberOfDigit < idealNumberOfDigit)
                {
                    idealNumberOfDigit = numberOfDigit;
                }
            }

            return idealNumberOfDigit;
        }

        public static int CalculateNumberOfDigit(int number)
        {
            number = Math.Abs(number);
            var numberOfDigit = 0;

            while (number > 0)
            {
                numberOfDigit++;
                number /= 10;
            }
            return numberOfDigit;
        }
    }
}
