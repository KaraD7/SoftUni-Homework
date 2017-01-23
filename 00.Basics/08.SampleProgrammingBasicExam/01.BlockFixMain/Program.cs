using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());
            //Math Abs, if result is with minus, Math Abs returns plus
            var side = Math.Abs (x2 - x3);
            var height = Math.Abs (y1 - y3);
            var area = (side * height) / 2.0;

            Console.WriteLine(area);

        }
    }
}
