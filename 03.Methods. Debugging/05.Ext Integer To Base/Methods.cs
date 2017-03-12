namespace _05.Ext_Integer_To_Base
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            var converted = IntegerToBase(number, toBase);
            Console.WriteLine(converted);
        }

        public static string IntegerToBase(int number, int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
