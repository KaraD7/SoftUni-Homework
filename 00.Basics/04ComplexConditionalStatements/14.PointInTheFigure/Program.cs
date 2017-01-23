using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if ((x>=0) && (x<=3*h) && (y>=0) && (y<=h))
            {
                if ((x > 0) && (x < 3 * h) && (y > 0) && (y < h))
                {
                    Console.WriteLine("Inside");
                }
                else if ((x=y) && (x)
                {

                }
            }
        }
    }
}
