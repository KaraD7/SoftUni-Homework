using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int leftSide = 0; leftSide <= n; leftSide++)
            {
                for (int interv = 0; interv < n-leftSide; interv++)
                {
                    Console.Write(" ");
                }
                
                for (int stars = 0; stars <= leftSide - 1; stars++)
                {
                    Console.Write("*");
                }

                Console.Write(" ");
                Console.Write("| ");

                for (int starsRight = 0; starsRight <= leftSide-1 ; starsRight++)
                {
                    Console.Write("*");
                }
              
                Console.WriteLine();
            }
        }
    }
}
