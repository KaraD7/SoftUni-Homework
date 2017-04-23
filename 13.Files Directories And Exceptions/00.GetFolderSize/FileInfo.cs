namespace _00.GetFolderSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class FileInfo
    {
        public static void Main()
        { 
            // size of a File
            string[] filenames = Directory.GetFiles("../../TestFolder"); // first
            double sumSize = 0;

            foreach (var file in filenames)
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                sumSize += fileInfo.Length;
            }
            /*Console.WriteLine(string.Join("\r\n", filenames));*/ // first
            //Console.WriteLine(sumSize / 1024 / 1024);

            File.WriteAllText("../../output.txt",(sumSize / 1024 / 1024)+ " MB");
        }
    }
}
