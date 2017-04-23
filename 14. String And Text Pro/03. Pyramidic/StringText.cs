namespace _03.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StringText
    {
        public static void Main()
        {
            List<string> pyraminds = new List<string>();

            int n = int.Parse(Console.ReadLine());

            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentCharacter = currentLine[j];
                    string currentPyramind = FindNewPyramid(i, currentCharacter, lines);
                    pyraminds.Add(currentPyramind.Trim());
                }
            }

            Console.WriteLine(pyraminds.OrderByDescending(x => x.Length).First());
        }

        private static string FindNewPyramid(int currentLineIndex, char currentCharacter, string[] lines)
        {
            int layer = 1;
            string curentPyramid = "";

            for (int k = currentLineIndex; k < lines.Length; k++)
            {
                string currentLayer = new string(currentCharacter, layer);

                if (lines[k].Contains(currentLayer))
                {
                    curentPyramid += currentLayer + "\r\n";
                }

                else
                {

                    break;
                }

                layer += 2;
            }

            return curentPyramid;

        }
    }
}
