namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            //    string[] participants = Console.ReadLine().Split(new[] { ',', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //        .Select(x => x.Trim())
            //        .ToArray();

            //    string[] avaliableSongs = Console.ReadLine().Split(new[] { ',', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //        .Select(x => x.Trim())
            //        .ToArray();

            //    Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();

            //    string inputLine = Console.ReadLine();

            //    while (inputLine != "dawn")
            //    {
            //        string[] singerInfo = inputLine.Split(new[] { ',', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
            //            .Select(x => x.Trim())
            //            .ToArray();

            //        string singer = singerInfo[0];
            //        string song = singerInfo[1];
            //        string award = singerInfo[2];

            //        // 
            //        if (!participants.Any(s => s == singer) ||
            //            !avaliableSongs.Any(s => s == song))
            //        {
            //            inputLine = Console.ReadLine();

            //            continue;
            //        }

            //        if (!winners.ContainsKey(singer))
            //        {
            //            winners.Add(singer, new List<string>());
            //        }

            //        winners[singer].Add(award);


            //        inputLine = Console.ReadLine();
            //    }

            //    if (winners.Count == 0)
            //    {
            //        Console.WriteLine("No awards");

            //        return;
            //    }

            //    foreach (KeyValuePair<string, List<string>> pair in winners
            //                                                        .OrderByDescending(a => a.Value.Distinct()
            //                                                        .ToList().Count)
            //                                                        .ThenBy(n => n.Key))
            //    {
            //        List<string> awards = pair.Value
            //            .Distinct()
            //            .ToList();

            //        Console.WriteLine($"{pair.Key}: {awards.Count} awards");

            //        foreach (string award in awards.OrderBy(n => n))
            //        {
            //            Console.WriteLine($"--{award}");
            //        }
            //    }
            //}

            var particiants = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var line = Console.ReadLine();
            var awardss = new Dictionary<string, HashSet<string>>();

            while (line != "dawn")
            {
                var tokens = line
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();


                var particiant = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (songs.Contains(song) && particiants.Contains(particiant))
                {
                    if (!awardss.ContainsKey(particiant))
                    {
                        awardss[particiant] = new HashSet<string>();
                    }

                    awardss[particiant].Add(award);

                }

                line = Console.ReadLine();

            }

            var sortedParticiantAwards = awardss
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var participantAward in sortedParticiantAwards)
            {
                var participant = awardss.Keys;
                var awards = awardss.Values;

                Console.WriteLine($"{participant}:  {awardss.Count} awards");

                foreach (var award in awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
