using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var gamesSofia = (48 - h) * (3.0/4);
            var games = p *(2.0/3);
            var result = gamesSofia + h + games;
            var leap = result * 0.15;

            switch (year)
            {
                case "leap": Console.WriteLine(Math.Truncate(result+leap));break;
                case "normal": Console.WriteLine(Math.Truncate(result));break;
                default:break;
            }
        }
    }
}
