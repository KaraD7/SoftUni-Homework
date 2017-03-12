namespace _04.ExtFloat_or_Integer
{
    using System;

    public class DataTypes
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number is int)
            {
                Console.WriteLine(number);
            }
            else if (number is double)
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
