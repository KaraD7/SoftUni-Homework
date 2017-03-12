using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();

            bool word = Convert.ToBoolean(firstWord);

            if (word == true)
            {
                Console.WriteLine("Yes");
            }
            else if (word == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
