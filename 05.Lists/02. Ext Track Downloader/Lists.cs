namespace _02.Ext_Track_Downloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            /*var listBlackWords = Console.ReadLine().Split().ToList();
            var listFilenames = Console.ReadLine().Split().ToList();
            var sortedList = new List<string>();

            for (int index = 0; index < listBlackWords.Count-1; index++)
            {
                for (int indexName = 0; indexName < listFilenames.Count-1; indexName++)
                {
                    if (listBlackWords[index] == listFilenames[indexName])
                    {
                        sortedList.Add(listBlackWords[indexName+1]);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sortedList);*/
            var blacklist = Console.ReadLine().Split();
            var line = Console.ReadLine();
            var downloadedTrack = new List<string>();
             
            while (line != "end")
            {
                var isInBlackList = false;

                foreach (var blacklistedWord in blacklist)
                {
                    if (line.Contains(blacklistedWord))
                    {
                        isInBlackList = true;
                        break;
                    }
                }

                if (!isInBlackList)
                {
                    downloadedTrack.Add(line);
                }

                line = Console.ReadLine();
            }

            downloadedTrack.Sort();

            foreach (var track in downloadedTrack)
            {
                Console.WriteLine(track);
            }

            //Console.WriteLine(string.Join(Environment.NewLine, downloadedTrack));

        }
    }
}
