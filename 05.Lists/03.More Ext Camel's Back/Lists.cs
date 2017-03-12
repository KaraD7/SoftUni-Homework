namespace _03.More_Ext_Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelBack = int.Parse(Console.ReadLine());

            var round = 0;

            while (buildings.Count > camelBack)
            {
                buildings.RemoveAt(0); // remove first
                buildings.Remove(buildings.Count-1); // remove last digit
                round++; // add rounds
            }

            if (round == 0)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine($"{round} round");
                Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
            }
        }
    }
}
