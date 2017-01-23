using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMetresX = int.Parse(Console.ReadLine());
            double harvestOneMetreY = double.Parse(Console.ReadLine());
            int needWineZ = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());

            double allGrape = squareMetresX * harvestOneMetreY;
            double allWine = Math.Abs((0.40 * allGrape) / 2.5);

            if (allWine >= needWineZ)
            {
                var resultWine = allWine - needWineZ;
                var resultWineWorker = resultWine / countWorkers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Truncate(allWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(resultWine), Math.Ceiling(resultWineWorker));
            }

            else if (allWine<needWineZ)
            {
                var needWine = Math.Truncate(needWineZ - allWine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", needWine);
            }
            
        }
    }
}
