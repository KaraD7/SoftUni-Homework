using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int lastSum = 0;
            int maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                //
                int sumNum = firstNum + secondNum;


                if (i > 0)
                {
                    // Differents between 1st sum and lastSum/
                    int diff = Math.Abs(sumNum - lastSum);

                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }

                }

                lastSum = sumNum;

            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value = {0}", lastSum);
            }
            else
            {
                Console.WriteLine("No, maxDiff = {0}", maxDiff);
            }
       
        }
    }
}
