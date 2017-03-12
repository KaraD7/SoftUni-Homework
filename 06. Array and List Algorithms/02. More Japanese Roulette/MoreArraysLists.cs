namespace _02.More_Japanese_Roulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MoreArraysLists
    {
        public static void Main()
        {
            var cyclings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // digits 0 1
            var directions = Console.ReadLine().Split().ToArray();                    // count,directions(R,L)



            for (int i = 0; i < cyclings.Length; i++)
            {
                if (cyclings[i] != 0)
                {

                }
            }

            /*public static void Main()
            {
                var cylinder = Console.ReadLine().Split().Select(int.Parse).ToList();
                var strengthAndDirection = Console.ReadLine().Split().ToArray();
                int bulletIndex = cylinder.IndexOf(1);
                int previusIndex = bulletIndex;

                for (int i = 0; i < strengthAndDirection.Length; i++)
                {
                    int currentPlayer = i;
                    string[] command = strengthAndDirection[i].Split(',');
                    int power = int.Parse(command[0]);

                    if (command[1] == "Right")
                    {
                        bulletIndex = (bulletIndex + power) % cylinder.Count;

                        if (bulletIndex == 2)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", currentPlayer);
                            return;
                        }

                        GetNewPossitionOfBullet(cylinder, bulletIndex, previusIndex);
                    }
                    else
                    {
                        bulletIndex = GetLeftStrength(cylinder, bulletIndex, power);

                        if (bulletIndex == 2)
                        {
                            Console.WriteLine("Game over! Player {0} is dead.", currentPlayer);
                            return;
                        }

                        GetNewPossitionOfBullet(cylinder, bulletIndex, previusIndex);
                    }

                    previusIndex = bulletIndex;
                    bulletIndex = (bulletIndex + 1) % cylinder.Count;
                    GetNewPossitionOfBullet(cylinder, bulletIndex, previusIndex);
                }

                Console.WriteLine("Everybody got lucky!");
            }

            private static void GetNewPossitionOfBullet(System.Collections.Generic.List<int> cylinder, int bulletIndex, int previusIndex)
            {
                cylinder[bulletIndex] = 1;
                cylinder[previusIndex] = 0;
            }

            private static int GetLeftStrength(System.Collections.Generic.List<int> cylinder, int bulletIndex, int power)
            {
                for (int r = 0; r < power; r++)
                {
                    bulletIndex--;

                    if (bulletIndex < 0)
                    {
                        bulletIndex = cylinder.Count;
                        r--;
                    }
                }

                return bulletIndex;
            }*/
        }
    }
}
