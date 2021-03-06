﻿namespace _08.Ext_String_Encryption
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                var encrypted = Encrypt(currentChar);
                result += encrypted;
            }
            Console.WriteLine(result);
        }

        public static string Encrypt(char currentChar)
        {
            var asciiCode = (int)currentChar;
            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit = GetLastDigit(asciiCode);

            var firstSymbol = (char)(asciiCode + lastDigit);
            var lastSymbol = (char)(asciiCode - firstDigit);
            var result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";

            return result;
        }

        public static int GetLastDigit(int asciiCode)
        {
            return asciiCode % 10;
        }

        public static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            return firstDigit;
        }
    }
}
