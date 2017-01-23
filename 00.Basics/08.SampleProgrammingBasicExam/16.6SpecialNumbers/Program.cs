using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._6SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 111111; i <= 999999; i++)
            {
                int num = i;
                int num6 = num % 10;//11111,1
                num = num / 10;//11111
                int num5 = num % 10;//1111,1


            }
        }
    }
}


           /* for (int i = 1; i <=9; i++)
            {
                for (int j = 1; i <=9; i++)
                {
                    for (int k = 1; i <=9; i++)
                    {
                        for (int d = 1; i <=9; i++)
                        {
                            for (int b = 1; b < length; b++)
                            {
                                for (int g = 0; g < length; g++)
                                {
                                    int result == i*j*k*d*b*g;
                                    
                                        if(n==)
                                        Console.WriteLine(" "+i+j+k+d+b+g);
                                }

                            }
                        }
                    }
                }
            }
        }
    }
   
}*/


