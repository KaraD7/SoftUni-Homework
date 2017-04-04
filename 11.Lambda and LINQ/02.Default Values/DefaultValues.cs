namespace _02.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DefaultValues
    {
        public static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '>', '-' }, StringSplitOptions.RemoveEmptyEntries);

                string key = inputParams[0];
                string value = inputParams[1];

                //dictionary.Add(key, value); wrong (if part of exercise)
                dictionary[key] = value; //associative array

                inputLine = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValue = dictionary
                 .Where(x => x.Value != "null")
                 .OrderByDescending(x => x.Value.Length)
                 .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> changedValue = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue); // 1st method

            foreach (var entry in unchangedValue)
            {
                Console.WriteLine("{0} <-> {1}", entry.Key, entry.Value);
            }

            foreach (var entry in changedValue)
            {
                Console.WriteLine("{0} <-> {1}", entry.Key, entry.Value);
            }
        }
    }
}
