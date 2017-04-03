namespace _2.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AdvancedDict
    {
        public static void Main()
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

            string inputLine = Console.ReadLine();

            while(inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>',',' }, StringSplitOptions.RemoveEmptyEntries);
                string currentKey = inputParams[0];
                int firstValue = -1;

                if (int.TryParse(inputParams[1], out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey))
                    {
                        dictionary[currentKey] = new List<int>();
                    }
                    for (int i = 1; i < inputParams.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputParams[i]));
                    }
                }
                else
                {
                    string otherKey = inputParams[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List <int>(dictionary[otherKey]);
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var entry in dictionary)
            {
                Console.WriteLine("{0} === {1}", entry.Key, string.Join(", ", entry.Value));
            }
        }
    }
}
