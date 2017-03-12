namespace _03.English_Name_of_Last_Digit
{
    using System;

    public class MethodsName
    {
        /*public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            PrintDigit(number);
        }

        public static void PrintDigit(long number)
        {
            var lastDigit = Math.Abs(number % 10);
            switch (lastDigit)
            {
                case 0: Console.WriteLine("zero");
                    break;
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                case 6: Console.WriteLine("six");
                    break;
                case 7: Console.WriteLine("seven");
                    break;
                case 8: Console.WriteLine("eight");
                    break;
                case 9: Console.WriteLine("nine");
                    break;
                default: Console.WriteLine();
                    break;
            }
        }*/
        public static void Main()
        {
            var num = long.Parse(Console.ReadLine());
            var lastDigit = GetLastDigit(num);
            var lastDigitAsWord = ConvertDigitToWord(lastDigit);
            Console.WriteLine(lastDigitAsWord);
        }

        public static string ConvertDigitToWord(long lastDigit)
        {
            var digitAsWord = string.Empty;
            switch (lastDigit)
            {
                case 0:
                    digitAsWord = "zero";
                    break;
                case 1:
                    digitAsWord = "one";
                    break;
                case 2:
                    digitAsWord = "two";
                    break;
                case 3:
                    digitAsWord = "three";
                    break;
                case 4:
                    digitAsWord = "four";
                    break;
                case 5:
                    digitAsWord = "five";
                    break;
                case 6:
                    digitAsWord = "six";
                    break;
                case 7:
                    digitAsWord = "seven";
                    break;
                case 8:
                    digitAsWord = "eight";
                    break;
                case 9:
                    digitAsWord = "nine";
                    break;
                default:
                    break;
            }
            return digitAsWord;
        }

        public static long GetLastDigit(long num)
        {
            var lastDigit = num % 10;
            return (int)Math.Abs(lastDigit);
        }
    }
}
