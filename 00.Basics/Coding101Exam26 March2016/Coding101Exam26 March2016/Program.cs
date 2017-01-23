using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding101Exam26_March2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            int allVegKg = int.Parse(Console.ReadLine());
            int allFruitKg = int.Parse(Console.ReadLine());

            var resultVeg = ((priceVegetable * allVegKg)/1.94);
            var resultFruit = ((priceFruit* allFruitKg)/1.94);
            var result = resultVeg + resultFruit;

            Console.WriteLine(result);
        
        }
    }
}
