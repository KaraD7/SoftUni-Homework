namespace _01.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class RegEx
    {
        public static void Main()
        {
            string inputCards = Console.ReadLine();

            //Regex regex = new Regex("([1]?[2-9JQKA])([SHDC])");
            Regex regex = new Regex(@"(?<![0-9]{1})([2-9JQKA]|10)([SHDC])");

            MatchCollection matchedCards = regex.Matches(inputCards);

            List<string> validCards = new List<string>();

            foreach (Match card in matchedCards)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                validCards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
