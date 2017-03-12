namespace _14.Extended_ASCII_String
{
    using System;

    public class DataTypes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = null;
            for (int i = 0; i < n; i++)
            {
                int numberFromTable = int.Parse(Console.ReadLine());
                
                char character = (char)numberFromTable;
                text = text + character.ToString();
                
                
            }
            Console.WriteLine($"{text}");

        }
    }
}
