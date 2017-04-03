namespace _00.ContinentCCitiesSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var data = new SortedDictionary<string,
                SortedDictionary<string,SortedSet<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
                }
                data[continent][country].Add(city);
            }
            foreach (var ContinentAndCountry in data)
            {
                var continentName = ContinentAndCountry.Key;
                var citiesByCountry = ContinentAndCountry.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var item in citiesByCountry)
                {
                    var country = item.Key;
                    var cities = item.Value;
                    Console.WriteLine($"  {country} --> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
