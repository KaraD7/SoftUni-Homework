using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double allPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine()); // time for every filtred every picture
            double filterFactor = double.Parse(Console.ReadLine()); // good pictures
            double uploadedTime = double.Parse(Console.ReadLine()); // time for picture to be uploaded

            double usefulPictures = Math.Ceiling (allPictures * (filterFactor / 100));
            double timeForPictures = allPictures * filterTime;
            double seconds = timeForPictures+(usefulPictures * uploadedTime);
            
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string result = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(result);
        }
    }
}
