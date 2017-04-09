namespace _00.Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class FileDirect
    {
        public static void Main()
        {
            string[] fileLines = File.ReadAllLines("input.txt");

            List<string> oddLines = new List<string>();

            for (int i = 1; i < fileLines.Length; i+=2)
            {
                oddLines.Add(fileLines[i]);
            }

            File.WriteAllLines("output.txt", oddLines);
        }
    }
}
