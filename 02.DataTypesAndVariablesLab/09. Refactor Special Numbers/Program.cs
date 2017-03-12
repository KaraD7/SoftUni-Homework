using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int num = 1; num <= count; num++)
            {
                int sumOfdigits = 0;
                int digits = num;
                bool specialNumber = false;
                while (digits > 0)
                {
                    sumOfdigits += digits % 10;
                    digits = digits / 10;
                }
                specialNumber = (sumOfdigits == 5) || (sumOfdigits == 7) || (sumOfdigits == 11);
                Console.WriteLine($"{num} -> {specialNumber}");
            }

        }
    }
}
