using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var sumP1 = p1 * h;
            var sumP2 = p2 * h;
            var sumPipes = (p1 *h) + (p2*h);

            var sumPipesPercent = sumPipes/(v / 100);
            var p1Percent = sumP1 / (sumPipes / 100);
            var p2Percent = sumP2 / (sumPipes / 100);

            if (sumPipes<=v)
            {

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1:f0}%. Pipe 2: {2:f0}%.",
                    (int)sumPipesPercent, (int)p1Percent, (int)p2Percent);
            }

            else if(sumPipes>v)
            {
                var more = sumPipes - v;

                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, more);
            }

        }
    }
}
