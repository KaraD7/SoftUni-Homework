namespace _002.Rotate_and_Sum
{
    using System;

    public class Arrays
    {
        public static void Main()
        {

            string[] inputNumbers = Console.ReadLine().Split(' ');
            int[] parsedNumbers = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                parsedNumbers[i]= int.Parse(inputNumbers[i]);
            }

            int n = int.Parse(Console.ReadLine());

            int[] sum = new int[parsedNumbers.Length];//sum the parsed numbers

            for (int i = 0; i < n; i++)
            {
                int lastNumbers = parsedNumbers[parsedNumbers.Length - 1];

                for (int j = parsedNumbers.Length-1; j > 0; j--)
                {
                    parsedNumbers[j] = parsedNumbers[j - 1];
                }

                parsedNumbers[0] = lastNumbers;

                for (int j = 0; j < parsedNumbers.Length; j++) // sum the numbers
                {
                    sum[j] += parsedNumbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
