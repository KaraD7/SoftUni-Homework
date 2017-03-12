using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            string result = null;
            var currentString = string.Empty;
            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                result += (currentString);
                if (i != numberOfStrings - 1) result += delimiter;
            }

            Console.WriteLine(result);
        }
    }
}