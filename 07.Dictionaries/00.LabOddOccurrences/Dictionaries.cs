namespace _00.LabOddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Dictionaries
    {
        public static void Main()
        {
            var stringWords = Console.ReadLine().
                ToLower().
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, int>();

            foreach (var word in stringWords)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }

            var oddNumberWords = new List<string>();

            foreach (var kvp in result)
            {
                var value = kvp.Value;
                if (value % 2 != 0)
                {
                    oddNumberWords.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumberWords));
        }
    }
}
