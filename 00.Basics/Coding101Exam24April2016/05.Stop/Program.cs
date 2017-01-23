using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var fullstop = n;
            int dash = 2 * n - 1;

            Console.WriteLine(new string('.', n+1) + new string('_', 2 * n + 1) + new string('.', n + 1));

            for (int fromSecondRow = 1; fromSecondRow <= n; fromSecondRow++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', fullstop), new string('_', (dash)));
                dash += 2;
                fullstop--;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', 2 * n - 3));
            fullstop = 0;
            dash = n * 4 - 1;

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', fullstop), new string('_', dash));
                fullstop++;
                dash -= 2;
            }
        }
    }
}
