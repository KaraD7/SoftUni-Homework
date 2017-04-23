namespace _1.Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StringTextProc
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {

                string[] inputParams = inputLine.Split(new[] { '.', ',', '>' });

                string sentences = inputParams[0].Trim();

                string[] elements = inputParams[1]
                    .Trim()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}"; // {0} {1}

                    sentences = sentences.Replace(currentPlaceholder, elements[i]);
                }
                Console.WriteLine(sentences);

                inputLine = Console.ReadLine();
            }
        }
    }
}
