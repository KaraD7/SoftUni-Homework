using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._6._06Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            /*int n = 5;
            int l = 5;
            */
            for (int num1  = 1; num1 <= n; num1++)
            {
                //10=10
                //0=0;
                //97->102;
                for (int num2 = 1; num2 <= n; num2++)
                {
                    for (int letter1 = 'a'/*97*/; letter1 < 'a'+l; letter1++)
                    {
                        //a =97
                        //b=98;
                        //c=99;
                        //d=100;
                        //e=101;

                        for (int letter2 = 'a'; letter2 < 'a'+l; letter2++)
                        {
                            for (int num3 = Math.Max(num2,num1)+1/*larger number*/; num3 <= n; num3++)
                            {
                                Console.Write(" " + num1+num2+(char)(letter1)+(char)(letter2)+num3);

                            }
                            
                        }
                    }
                }
            }
        }
    }
}
