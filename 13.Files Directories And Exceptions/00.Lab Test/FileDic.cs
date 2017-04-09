namespace _00.Lab_Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class FileDic
    {
        public static void Main()
        {
            //class File


            //string file = File.ReadAllText("test.txt");

            //Console.WriteLine(file);

            //string[] fileLine = File.ReadAllLines("test.txt");

            //Console.WriteLine(string.Join(" ", fileLine));

            //string joinedLineWrite = string.Join(" ", fileLine);

            //File.WriteAllText("outText.txt", joinedLineWrite); // add new txt file, but every time delete old text, add new

            // new exr

            //string fileContent = File.ReadAllText("test.txt");

            //Console.WriteLine(fileContent);

            //List<string> elements = fileContent.Split(' ').ToList();

            //File.WriteAllLines("../test.txt", elements);

            // exr Appen

            //string fileContent = File.ReadAllText("test.txt");

            //List<string> elements = fileContent.Split(' ').ToList();

            //File.AppendAllLines("out.txt", elements); // add new text, save old

            //// File.Create

            //File.Create("create-file.txt");

            // File.copy
            //File.Exists
            //
            // class File info

            //FileInfo file = new FileInfo("test.txt");
            //Console.WriteLine(file.Directory);

            // 
            FileInfo file = new FileInfo("test.txt");
            Console.WriteLine(file.CreationTime);

        }
    }
}
