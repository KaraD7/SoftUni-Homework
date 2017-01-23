using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenMax = -1000000000.0;
            double evenMin = 1000000000.0;
            double evenSum = 0;

            double oddSum = 0;
            double oddMax = -1000000000.0;
            double oddMin = 1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i%2==0)
                {
                    evenSum += number;


                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (oddMin > number)
                    {
                        oddMin = number;
                    }

                }
            }

            if (n == 1)
            {
                evenSum += evenSum;
                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = No, EvenMax = No", oddSum, oddMin, oddMax, evenSum);

            }
            else if (n == 0)
            {
                oddSum += oddSum;
                evenSum += evenSum;
                Console.WriteLine("OddSum = {0}, OddMin = No, OddMax = No, EvenSum = {1}, EvenMin = No, EvenMax = No", oddSum, evenSum);
            }

            else
            {

                Console.WriteLine("OddSum = {0}, OddMin = {1}, OddMax = {2}, EvenSum = {3}, EvenMin = {4}, EvenMax = {5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
        }
    }
}
