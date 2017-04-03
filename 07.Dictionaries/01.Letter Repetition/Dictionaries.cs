﻿namespace _01.Letter_Repetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Dictionaries
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var dict = new Dictionary<char, int>();

            GetSymbolOccurance(inputString, dict);

            PrintResult(dict);
        }

        private static void PrintResult(Dictionary<char, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private static void GetSymbolOccurance(string inputString, Dictionary<char, int> dict)
        {
            foreach (var symbol in inputString)
            {
                if (!dict.ContainsKey(symbol))
                {
                    dict[symbol] = 0;
                }

                dict[symbol]++;
            }
        }
    }
}