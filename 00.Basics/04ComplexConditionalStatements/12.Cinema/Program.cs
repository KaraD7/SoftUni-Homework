using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine().ToLower());
            var columns = int.Parse(Console.ReadLine());
            var result = rows * columns;

            switch (type)
            {
                case "premiere": Console.WriteLine("{0:f2}",result*12.00);Console.WriteLine("leva");break;
                case "normal": Console.WriteLine("{0:f2}", result*7.50);Console.WriteLine("leva"); break;
                case "discount": Console.WriteLine("{0:f2} leva", result*5.00);break;
                default:break;
            }
        }
    }
}
