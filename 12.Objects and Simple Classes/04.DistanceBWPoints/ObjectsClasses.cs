namespace _04.DistanceBWPoints  // SQRT ((x1-x2)^2 +(y1-y2)^2)
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //public class Point
    //{
    //    public double X { get; set; }

    //    public double Y { get; set; }
    //}
    public class ObjectsClasses
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result); // $"{result:F3}"
        }

        public static double Distance(Point First, Point Second)
        {
            var squareX = Math.Pow(First.X - Second.X, 2);
            var squareY = Math.Pow(First.Y - Second.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
