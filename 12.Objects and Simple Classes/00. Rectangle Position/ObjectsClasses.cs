namespace _00.Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ObjectsClasses
    {
        public static void Main()
        {
            var firstRect = ReadRectangel();
            var secondRect = ReadRectangel();

            var result = firstRect.IsInSide(secondRect);
            var printResult = result 
                ? "Inside" 
                : "Not inside"; //first method
            Console.WriteLine(printResult);

            //if (result) //second method
            //{
            //    Console.WriteLine("Inside");
            //}
            //else
            //{
            //    Console.WriteLine("Not Inside");
            //}
        }
        public static Rectangle ReadRectangel()
        {
            var rectangelParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            return new Rectangle
            {
                Left = rectangelParts[0],
                Top = rectangelParts[1],
                Width = rectangelParts[2],
                Height = rectangelParts[3],
            };
        }
    }
}
