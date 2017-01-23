using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string dn = Console.ReadLine();
            var taxiD = 0.70 + (0.79 * n);
            var taxiN = 0.70 + (0.90 * n);
            var bus = 0.09 * n;
            var train = 0.06 * n;

            if (n < 20 && dn == "day")
            {
                Console.WriteLine(taxiD);
            }
            else if (n < 20 && dn == "night")
            {
                Console.WriteLine(taxiN);
            }
            else if (n >= 20)
                if (bus < train)
                {
                    Console.WriteLine(bus);
                }
                else if (train >= bus)
                {
                    Console.WriteLine(train);
                }
            }

        }
    }