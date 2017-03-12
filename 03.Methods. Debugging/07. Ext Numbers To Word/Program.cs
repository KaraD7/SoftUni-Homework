using System;
namespace _07.Ext_Numbers_To_Word
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var result = string.Empty;
            var text = string.Empty;

            for (int i = 0; i < number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers > 999)
                {
                    text = "too large";
                }
                else if (numbers > -999)
                {
                    text = "too small";
                }
                else if (numbers < 0 && numbers >= -999)
                {
                    text = "minus";
                }
                else if (numbers < 100)
                {
                    numbers = 0;
                }
                else
                {
                    number = 123;
                }

                result = result + NumberToWords(numbers) + Environment.NewLine;
            }
            Console.WriteLine(text+result);
        }

        public static string NumberToWords(int number)
        {

            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + "-hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six",
                                    "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen",
                                    "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy",
                                    "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
