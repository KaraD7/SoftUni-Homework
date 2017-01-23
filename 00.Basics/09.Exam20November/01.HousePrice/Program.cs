using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareSmallRoom = double.Parse(Console.ReadLine());
            double kitchenSq = double.Parse(Console.ReadLine());
            double priceKitchen = double.Parse(Console.ReadLine());

            double secondRoom = squareSmallRoom + (squareSmallRoom * 0.10);
            double thirdRoom = secondRoom + (secondRoom * 0.10);
            double bathroom = squareSmallRoom / 2;
            double allSquare = squareSmallRoom + kitchenSq + secondRoom + thirdRoom+bathroom;
            double squareWithHall = allSquare + (allSquare * 0.05);
            double price = squareWithHall * priceKitchen;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
