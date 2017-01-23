using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        { 
            var age = double.Parse(Console.ReadLine());
            var priceWashM = double.Parse(Console.ReadLine());
            var priceToy = double.Parse(Console.ReadLine());

            var even = 0;
            var odd = 0;
            var sumMoney = 0;
            var money = 0;
            double moneyForWashM = 0;
            double change = 0;

                for (int i = 1; i <= age; i++)
            {
                if (i%2==0)
                {
                    sumMoney = sumMoney+10;
                    money = money + sumMoney;
                    even++;

                }
                else
                {
                    odd++;
                }

            }
            moneyForWashM = (odd * priceToy) + (money - even);

            if (moneyForWashM >= priceWashM)
            {
                change = moneyForWashM - priceWashM;
                Console.WriteLine("Yes! {0:f2}", change);

            }
            else if(moneyForWashM < priceWashM)
            {
                change = priceWashM - moneyForWashM;
                Console.WriteLine("No! {0:f2}", (change));
            }
            


        }
    }
}
