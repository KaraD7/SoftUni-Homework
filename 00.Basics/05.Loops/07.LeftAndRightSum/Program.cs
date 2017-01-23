using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var leftSide = 0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftSide += number;
            }

            var rightSide = 0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightSide += number;
            }
            if (rightSide == leftSide)
            {
                Console.WriteLine("Yes, sum = {0}", leftSide);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(rightSide-leftSide));
            }
        }
    }
}
