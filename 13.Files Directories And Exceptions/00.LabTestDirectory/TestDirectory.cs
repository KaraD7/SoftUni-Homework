namespace _00.LabTestDirectory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class TestDirectory
    {
        public static void Main()
        {
            //Directory.CreateDirectory("Test");
            //Directory.CreateDirectory("Test/InnerTest2");
            //File.Create("Test/output.txt");

            //Directory.CreateDirectory("OuterDirectory/InnerDirectory");
            //Directory.Move("OuterDirectory/InnerDirectory", "../..output"); // must be exist the directory
            //
            //string[] fileNames = Directory.GetFiles("Test");
            //Console.WriteLine(string.Join("\r\n",
            //    fileNames
            //    .Select(x => x.Replace("Test\\",""))
            //    .Select(x => string.Join(".", x.Split('.').Reverse().Skip(1).Reverse())))); // remove the file extension

            //
            string[] subDirectoryNames = Directory.GetDirectories("Test");

            foreach (var subDirectory in subDirectoryNames)
            {
                Console.WriteLine("{0}", subDirectory.Replace("Test\\", ""));

                string[] fileNames = Directory.GetFiles(subDirectory);

                foreach (var file in fileNames)
                {
                    Console.WriteLine("***  {0}", file.Split('\\')[file.Split('\\').Length-1]);
                }
            }

        }
    }
}
