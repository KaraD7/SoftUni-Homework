using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int topRowsTriangle = 1; topRowsTriangle <= n; topRowsTriangle++)
            {
                for (int blank = 1; blank <= n - topRowsTriangle; blank++)
                {

                    Console.Write(" ");

                }
                Console.Write("*");

                for (int dashStar = 1; dashStar <= topRowsTriangle - 1; dashStar++)
                {
                    Console.Write("-*");

                }
                Console.WriteLine();
                
            }
            for (int bottomRowsTriangle = 1; bottomRowsTriangle <= n-1; bottomRowsTriangle++)
            {
                for (int blank = 1; blank <= bottomRowsTriangle ; blank++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int dashStar = 1; dashStar < n-bottomRowsTriangle; dashStar++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
