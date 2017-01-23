using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int colCount = n / 2;
            int dashCount = 2 * n - 2 * (n / 2) - 4;


            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^',colCount), new string ('_', dashCount));

            for (int middle = 0; middle < n-2; middle++)
            {
                Console.WriteLine("|{0}|",new string(' ', 2  * n -2 ));
            
            }

           
            // Draw the row before the last
            Console.WriteLine("|{0}{1}{0}|", new string(' ', colCount + 1), new string('_', dashCount));
            // Draw the last row
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colCount), new string(' ', dashCount));
        }
    
    }
}
