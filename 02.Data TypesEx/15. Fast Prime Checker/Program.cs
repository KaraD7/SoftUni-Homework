using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool primeNum = true;
                for (int checkNum = 2; checkNum <= Math.Sqrt(i); checkNum++)
                {
                    if (i % checkNum == 0)
                    {
                        primeNum = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {primeNum}");
            }

        }
    }
}
