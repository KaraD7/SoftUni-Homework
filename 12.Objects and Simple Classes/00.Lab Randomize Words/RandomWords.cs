namespace _00.Lab_Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RandomWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var randomWords = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPossiton = randomWords.Next(0, words.Length);

                var temporaryWord = words[randomPossiton];
                words[randomPossiton] = currentWord;
                words[i] = temporaryWord;
            }
            foreach (var resultWord in words)
            {
                Console.WriteLine(resultWord);
            }
        }
    }
}
