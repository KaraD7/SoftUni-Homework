namespace _06.More_Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var grapes = Console.ReadLine().Split().Select(int.Parse).ToList();
            var growthDays = int.Parse(Console.ReadLine());

            for (int i = 0; i < grapes.Count; i++) //
            {
                grapes[i]++;
            }

            for (int i = 0; i < grapes.Count; i++)
            {
                var isFirstElement = i == 0;
                var isLastElement = i == grapes.Count-1;

                if (!isFirstElement && !isLastElement)
                {
                    var previousIndex = i - 1;
                    var nextIndex = i + 1;

                    var isGreaterThanPrevious = grapes[i] > grapes[previousIndex];
                    var greaterThanNext = grapes[i] > grapes[nextIndex];

                    var isGreaterGrape = isGreaterThanPrevious && greaterThanNext;

                    if(isGreaterGrape)
                    {
                        grapes[i]--;

                        if (grapes[previousIndex] > 0)
                        {
                            grapes[i]++;
                        }

                        if (grapes[nextIndex] > 0)
                        {
                            grapes[i]++;
                        }
                    }
                }
            }
        }
    }
}
