
namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    /*public class Shellbound
    {
        public static void Main()
        {
            
            var inputLine = Console.ReadLine().Split().ToList();
            var placeAndAmount = new Dictionary<string, List<int>>();

            while (inputLine[0] != "Aggregate")
            {
                var regionName = inputLine[0];
                var shell = int.Parse(inputLine[1]);

                if (!placeAndAmount.ContainsKey(regionName))
                {
                    placeAndAmount[regionName] = new List<int>();
                }
                placeAndAmount[regionName].Add(shell);
                Console.ReadLine();
            }

            foreach (var resultShell in placeAndAmount)
            {                                                                        //list of double
                Console.WriteLine("{0} -> {1} ", resultShell.Key,
                    string.Join(" ", resultShell.Value.Select(p => string.Format("{0:f2}", p))),  // transformation
                    resultShell.Value.Average());

            }
        }*/
    class Shellbound
    {
        static void Main()
        {
            var inputLine = Console.ReadLine().Split().ToArray();

            var regions = new Dictionary<string, HashSet<int>>();

            while (inputLine[0] != "Aggregate")
            {
                AddingRegionsAndShells(inputLine, regions);

                inputLine = Console.ReadLine().Split().ToArray();
            }

            PrintResult(regions);
        }

        private static void PrintResult(Dictionary<string, HashSet<int>> regions)
        {
            foreach (var region in regions)
            {
                int shellsSum = region.Value.Sum();
                int average = shellsSum / region.Value.Count;
                int shellsCount = shellsSum - average;

                if (region.Value.Count < 2)
                {
                    average = region.Value.Sum();
                }

                Console.WriteLine($"{region.Key} -> {string.Join(", ", region.Value)} ({shellsCount})");
            }
        }

        private static void AddingRegionsAndShells(string[] inputLine, Dictionary<string, HashSet<int>> regions)
        {
            var region = inputLine[0];
            var shellSize = int.Parse(inputLine[1]);

            if (!regions.ContainsKey(region))
            {
                regions[region] = new HashSet<int>();
            }

            regions[region].Add(shellSize);
        }
    }
}
