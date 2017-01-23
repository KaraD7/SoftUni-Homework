using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int i1 = i; i1 <n-4 ; i1++)
                {
                    for (int i2 = i1; i2 < n-3; i2++)
                    {
                        for (int i3 = i2; i3 < n-2; i3++)
                        {
                            for (int i4 = i3; i4 < n-1; i4++)
                            {
                                for (int i5 = i4; i5 <n; i5++)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", i,i1,i2,i3,i4, i5 );
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
