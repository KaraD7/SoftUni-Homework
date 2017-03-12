using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        char letterA = (char)('a' + first);
                        char letterB = (char)(('b'+ second)- 1);
                        char letterC = (char)(('c' + third) - 2);
                        Console.WriteLine("{0}{1}{2}", letterA, letterB, letterC);

                    }
                }
            }
        }
    }
}
