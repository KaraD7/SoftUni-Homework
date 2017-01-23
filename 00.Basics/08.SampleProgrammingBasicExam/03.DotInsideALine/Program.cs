using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DotInsideALine
{
    class Program
    {
        static void Main(string[] args)
        {
            int xFirst = int.Parse(Console.ReadLine());
            int xSecond = int.Parse(Console.ReadLine());
            int xPoint = int.Parse(Console.ReadLine());

            int left = Math.Min(xFirst, xSecond);
            int right = Math.Max(xFirst, xSecond);

            int distanceFromLeft = Math.Abs(left - xPoint);
            int distanceFromRight = Math.Abs(right - xPoint);

            if (xPoint >= left && xPoint <= right)
            {

                Console.WriteLine("in");
                Console.WriteLine(Math.Min(distanceFromLeft,distanceFromRight));

            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(distanceFromLeft, distanceFromRight));
            }
            
        }
    }
}
