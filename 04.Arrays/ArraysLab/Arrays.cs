namespace ArraysLab
{
    using System;

    public class Arrays
    {
        public static void Main()
        {
            var numberOfElements = int.Parse(Console.ReadLine()); // if 3

            var numbers = new int[numberOfElements]; // 3

            for (int i = 0; i < numbers.Length; i++) // or numberOfElements 
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
