using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            

            if (figure == "square")
            {
                var squareL = double.Parse(Console.ReadLine());
                squareL = squareL * squareL;

                Console.WriteLine("{0}", Math.Round(squareL,3));
            }
            else if (figure == "rectangle")
            {
                var rectangleL1 = double.Parse(Console.ReadLine());
                var rectangleL2 = double.Parse(Console.ReadLine());
                var rectangleResult = rectangleL1 * rectangleL2;

                Console.WriteLine(Math.Round(rectangleResult,3));
            }
            else if (figure == "circle")
            {
                var circle = double.Parse(Console.ReadLine());
                var circleResult = Math.PI * circle * circle;

                Console.WriteLine(Math.Round(circleResult,3));
            }
            else if (figure == "triangle")
            {
                var triangleS = double.Parse(Console.ReadLine());
                var triangleH = double.Parse(Console.ReadLine());
                var triangleResult = (triangleS*triangleH) / 2;

                Console.WriteLine(Math.Round(triangleResult, 3));
            }
        }
    }
}
