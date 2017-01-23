using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int count = int.Parse(Console.ReadLine());
            
            int sum = 0;

            int tones200Lev = 0;
            int tones175Lev = 0;
            int tones120Lev = 0;

            int tones200sum = 0;
            int tones175sum = 0;
            int tones120sum = 0;

            double sum200 = 0;
            double sum175 = 0;
            double sum120 = 0;


            for (int i = 1; i <= count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum+num;
 

                if (num<=3)
                {
                    sum200 = sum200 + num;
                    tones200Lev = num*200;
                    tones200sum = tones200sum + tones200Lev;
                }
                else if (num>=4 && num <=11)
                {
                    sum175 = sum175 + num;
                    tones175Lev = num*175;
                    tones175sum = tones175sum + tones175Lev;
                }
                else if (num>=12)
                {
                    sum120 = sum120 + num;
                    tones120Lev = num*120;
                    tones120sum = tones120sum + tones120Lev;
                }
            }

            double all = (tones120sum + tones175sum + tones200sum) / sum;
            double withBus = (sum200 /sum )* 100;
            double withKam = (sum175 /sum )* 100;
            double withTrain = (sum120 / sum )* 100;

            Console.WriteLine("{0:f2}",all);
            Console.WriteLine("{0:f2}%",withBus);
            Console.WriteLine("{0:f2}%",withKam);
            Console.WriteLine("{0:f2}%",withTrain);
            
            
        }
    }
}
