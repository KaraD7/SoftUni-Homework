namespace _00.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ObjectsClasses
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minimumDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = Distance(firstPoint, secondPoint);

                    if (distance < minimumDistance)
                    {
                        minimumDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minimumDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
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
