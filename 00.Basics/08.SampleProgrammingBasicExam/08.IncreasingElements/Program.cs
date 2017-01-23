using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var previousNumber = -1000;
            var count = 0;
            var maxCount = 0;

            for (int i = 1; i <= n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > previousNumber)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }

                previousNumber = currentNumber;


            }
            Console.WriteLine(maxCount);
        }
    }
}
