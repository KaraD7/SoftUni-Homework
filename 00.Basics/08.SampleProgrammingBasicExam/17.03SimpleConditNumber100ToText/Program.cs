using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._03SimpleConditNumber100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            

            switch (number)
            {   
                case 20: Console.WriteLine("twenty");break;
                case 30: Console.WriteLine("thirty");break;
                case 40: Console.WriteLine("forty"); break;
                case 50: Console.WriteLine("fifty"); break;
                case 60: Console.WriteLine("sixty"); break;
                case 70: Console.WriteLine("seventy"); break;
                case 80: Console.WriteLine("eighty"); break;
                case 90: Console.WriteLine("ninty"); break;
                default:
                    break;
            }
            

        }
    }
}
