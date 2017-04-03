using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeters = new char[] { ' ', '-', '>', ',' };
            var inputLine = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var topicsAndTags = new Dictionary<string, HashSet<string>>();

            while (inputLine[0] != "filter")
            {
                inputLine = AddingTagsAndTopics(delimeters, inputLine, topicsAndTags);
            }

            var filters = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            PrintResult(topicsAndTags, filters);
        }

        private static string[] AddingTagsAndTopics(char[] delimeters, string[] inputLine, Dictionary<string, HashSet<string>> topicsAndTags)
        {
            var topic = inputLine[0];

            if (!topicsAndTags.ContainsKey(topic))
            {
                topicsAndTags[topic] = new HashSet<string>();
            }

            for (int i = 1; i < inputLine.Length; i++)
            {
                var tag = inputLine[i];
                topicsAndTags[topic].Add(tag);
            }

            inputLine = Console.ReadLine().Split(delimeters, StringSplitOptions.RemoveEmptyEntries).ToArray();
            return inputLine;
        }

        private static void PrintResult(Dictionary<string, HashSet<string>> topicsAndTags, string[] filters)
        {
            foreach (var topic in topicsAndTags)
            {
                bool isContainsTag = true;

                foreach (var filter in filters)
                {
                    if (!topic.Value.Contains(filter))
                    {
                        isContainsTag = false;
                        break;
                    }
                }

                if (isContainsTag)
                {
                    var tags = new List<string>();
                    foreach (var tag in topic.Value)
                    {
                        tags.Add("#" + tag);
                    }

                    Console.WriteLine($"{topic.Key} | {string.Join(", ", tags)}");
                }
            }
        }
    }
}
