using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int firstRow = 0; firstRow < 1; firstRow++)
            {
                for (int starsLeft = 0; starsLeft < 2 * n; starsLeft++)
                {
                    Console.Write("*");
                }
                for (int interval = 0; interval < n; interval++)
                {
                    Console.Write(" ");
                }
                for (int starsRight = 0; starsRight < 2 * n; starsRight++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int middleRow = 0; middleRow < n-2; middleRow++)
            {
                Console.Write("*");

                for (int slash = 0; slash < 2*n-2; slash++)
                {
                    Console.Write("/");
                }

                Console.Write("*");

                
                    if (middleRow == (n - 1) / 2 - 1)
                    {
                        Console.Write(new string ('|', n));
                    }
                    else
                    {
                        Console.Write(new string (' ', n));
                    }

                Console.Write("*");

                for (int slash = 0; slash < 2*n-2; slash++)
                {
                    Console.Write("/");
                }

                Console.Write("*");
                Console.WriteLine();
            }

            for (int lastRow = 0; lastRow < 1; lastRow++)
            {
                for (int starsLeft = 0; starsLeft < 2*n; starsLeft++)
                {
                    Console.Write("*");
                }
                for (int interval = 0; interval < n; interval++)
                {
                    Console.Write(" ");
                }
                for (int starsRight = 0; starsRight < 2*n; starsRight++)
                {
                    Console.Write("*");
                }
            }
            
        }
    }
}
