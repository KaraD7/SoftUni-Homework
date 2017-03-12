namespace _04.Ext_Nth_Digit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Methods
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            FindNthDigit(number, index);
        }

        public static int FindNthDigit(long number, int index)
        {
            while (index == 0)
            {

            }
            return;
        }
    }
}
/*using System;
namespace Uprajnenie4
{
    class Uprajnenie4
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            //double a = Math.Pow(n, -1);
            double nDigit = (int)((number / (Math.Pow(10, (n - 1))) % 10));
            Console.WriteLine("{0}", nDigit);
            
        }
    }
}
*/