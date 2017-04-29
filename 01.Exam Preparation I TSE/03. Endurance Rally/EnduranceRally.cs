namespace _03.Endurance_Rally
{
    using System;
    using System.Linq;
    public class EnduranceRally
    {
        public static void Main()
        {
            //string [] inputName = Console.ReadLine().Split(' ').ToArray();
            //var zones = Console.ReadLine().Split(' ').ToArray();
            //var index = Console.ReadLine().Split(' ').ToArray();

            //for (int i = 0; i < inputName.Length; i++)
            //{
            //    var name = inputName[i];
            //    var nameeee = name[0];

            //    Console.WriteLine(Convert.ToInt32(nameeee));
            //}

            //for (int i = 0; i < index.Length; i++)
            //{
            //    var indexFor = index[i];

            //    for (int j = 0; j < zones.Length; j++)
            //    {
            //        var zonesFor = indexFor[j];

            //    }
            //}
            //Console.WriteLine(string.Join(" , ", inputName));

            var participants = Console.ReadLine().Split();

            var trackIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkpointIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var participant in participants)
            {
                double fuel = participant[0];

                for (int currentTrackIndex = 0; currentTrackIndex <= trackIndices.Length; currentTrackIndex++)
                {
                    bool outOfFuel = fuel <= 0;
                    bool reachedEndOfTrack = currentTrackIndex == trackIndices.Length;
                    var raceEnded = outOfFuel || reachedEndOfTrack;

                    if (raceEnded)
                    {
                        if (outOfFuel)
                        {
                            Console.WriteLine($"{participant} - reached {currentTrackIndex-1}");
                        }
                        else if(reachedEndOfTrack)
                        {
                            Console.WriteLine($"{participant} - fuel left {fuel:F2}");
                        }

                        break;
                    }

                    var fuelAtCheckpoint = trackIndices[currentTrackIndex];
                    var isCheckpoint = checkpointIndices.Contains(currentTrackIndex);

                    if (isCheckpoint)
                    {
                        fuel += fuelAtCheckpoint;
                    }
                    else
                    {
                        fuel -= fuelAtCheckpoint;
                    }
                    
                }
            }
        }
    }
}
