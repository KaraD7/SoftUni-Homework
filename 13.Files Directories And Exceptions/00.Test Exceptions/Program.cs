using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _00.Test_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new IOException("Ne me ....");

            try
            {
                File.ReadAllLines("unexisted.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            finally // finaly block/ everytime write /+ catch or try
            {

            }
        }
    }
}
