namespace _02.Default_Values2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DefaultValue2
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

            dictionary
                 .Where(x => x.Value != "null")
                 .OrderByDescending(x => x.Value.Length)
                 .ToList()
                 .ForEach(x => Console.WriteLine("{0} <-> {1}", x.Key, x.Value));

            dictionary
                .Where(x => x.Value == "null")
                .Select(x => x.Key + " <-> " + defaultValue)
                .ToList()
                .ForEach(Console.WriteLine);
            
        }
    }
}
