using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthSide = int.Parse(Console.ReadLine());
            double wideTile = double.Parse(Console.ReadLine());
            double lengthTile = double.Parse(Console.ReadLine());
            int wideBench = int.Parse(Console.ReadLine());
            int lengthBench = int.Parse(Console.ReadLine());

            var squareArea = lengthSide * lengthSide;
            var squareBench = wideBench * lengthBench;
            var squareTile = wideTile * lengthTile;

            var needSqMetres = squareArea - squareBench;
            var needTiles = needSqMetres / squareTile;
            var needTime = needTiles * 0.2;

            Console.WriteLine(needTiles);
            Console.WriteLine(needTime);

        }
    }
}
