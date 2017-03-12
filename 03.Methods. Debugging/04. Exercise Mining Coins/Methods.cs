namespace _04.Debugging_Exercise_Mining_Coins
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;  // for text
            float totalValue = 0;   // for sum

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int firstDigit = number / 100; 
                int middleDigit = (number % 100) / 10;
                int lastDigit = number % 10;

                totalValue += (firstDigit + middleDigit + lastDigit) / (float)count; // sum 
                int ASCIIcode = 0;

                if (i % 2 == 0)// even
                {
                    ASCIIcode = ((firstDigit * 10) + lastDigit) + middleDigit;
                    decrypted += (char)ASCIIcode;
                }
                else // odd
                {
                    ASCIIcode = ((firstDigit * 10)+lastDigit) - middleDigit;
                    decrypted += (char)ASCIIcode;
                }

                if ((ASCIIcode >= 65 && ASCIIcode <= 90) && (ASCIIcode >= 97 && ASCIIcode <= 122))
                {
                    decrypted += (char)ASCIIcode;
                }
            }

            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}