using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var sumEven = 0;
            var sumOdd = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }

            if (sumEven==sumOdd)
            {
                Console.WriteLine("Yes, sum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumEven-sumOdd));
            }

        }
    }
}
