namespace _00.CitiesContCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CitiesContCountry
    {
        public static void Main()
        {
            var townsDict = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var lineData = Console.ReadLine().Split();
                var continent = lineData[0];
                var country = lineData[1];
                var town = lineData[2];

                AddTown(townsDict, continent, country, town);
            }

            foreach (var continent in townsDict.Keys)
            {
                Console.WriteLine("{0}:", continent);
                var townsInContinent = townsDict[continent];

                foreach (var country in townsInContinent.Keys)
                {
                    Console.WriteLine("  {0} --> {1}",
                        country, 
                        string.Join(", ", townsInContinent[country]));
                }
            }
        }
        public static void AddTown(
            Dictionary<string, Dictionary<string, List<string>>>towns,
            string continent, string country, string town)
        {
            if (!towns.ContainsKey(continent))
                towns[continent] = new Dictionary<string, List<string>>();

            if (!towns[continent].ContainsKey(country))
                towns[continent][country] = new List<string>();

            towns[continent][country].Add(town);
        }
    }
}
