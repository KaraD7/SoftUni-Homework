using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n - 2; rows++)
            {
                if (rows % 2 == 0)
                {
                    Console.WriteLine("{0}\\{1}/{0}", new string('*', n - 2), new string(' ', n / n));
                   
                }
                else
                {
                    
                    Console.WriteLine("{0}\\{1}/{0}", new string('-', n - 2), new string(' ', n / n));
                    
                }
            }
            Console.WriteLine("{0} @ {0}",new string(' ', n-2));

            for (int rows = 0; rows < n - 2; rows++)
            {
                if (rows % 2 == 0)
                {
                    Console.WriteLine("{0}/{1}\\{0}", new string('*', n - 2), new string(' ', n / n));

                }
                else
                {

                    Console.WriteLine("{0}/{1}\\{0}", new string('-', n - 2), new string(' ', n / n));

                }
            }
        }
    }
}
