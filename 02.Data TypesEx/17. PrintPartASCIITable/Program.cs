using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());


            for (int symbol = numberOne; symbol <= numberTwo; symbol++)
            {
                
                char character = (char)symbol;
                string text = character.ToString();
                Console.Write($"{text} ");
            }
            Console.WriteLine();
        }
    }
}
