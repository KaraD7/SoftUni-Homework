using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            try
            {
                long number = long.Parse(inputNumber);
                Console.WriteLine("{0} can fit in:", number);
            }
            catch (OverflowException)
            {

            }
            try
            {
                sbyte number = sbyte.Parse(inputNumber);
                Console.WriteLine("* sbyte");
            }
            catch (OverflowException)
            {

            }
            try
            {
                byte number = byte.Parse(inputNumber);
                Console.WriteLine("* byte");
            }
            catch (OverflowException)
            {

            }
            try
            {
                short number = short.Parse(inputNumber);
                Console.WriteLine("* short");
            }
            catch (OverflowException)
            {

            }
            try
            {
                ushort number = ushort.Parse(inputNumber);
                Console.WriteLine("* ushort");
            }
            catch (OverflowException)
            {

            }
            try
            {
                int number = int.Parse(inputNumber);
                Console.WriteLine("* int");
            }
            catch (OverflowException)
            {

            }
            try
            {
                uint number = uint.Parse(inputNumber);
                Console.WriteLine("* uint");
            }
            catch (OverflowException)
            {

            }
            try
            {
                long number = long.Parse(inputNumber);
                Console.WriteLine("* long");
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} can't fit in any type", inputNumber);
            }
        }
    }
}
