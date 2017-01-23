using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var volume = int.Parse(Console.ReadLine());

            double courses = (workers * volume);
            double bricksFromCourses = bricks / courses;

           
            Console.WriteLine(Math.Ceiling(bricksFromCourses));
           

        }
    }
}
