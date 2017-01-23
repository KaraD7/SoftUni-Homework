using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > max)
                {
                    max = number;
                }
                sum = sum + number;
            }

            sum = sum - max;

            if (sum == max)
            {
                Console.WriteLine("Yes, Sum = {0}", sum);
            }
            else
            {
                var diff = Math.Abs(max - sum);
                Console.WriteLine("No, Diff = {0}", diff);
            }

        }
    }
}
