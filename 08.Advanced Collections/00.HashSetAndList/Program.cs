using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.HashSetAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            HashSet<string> hashSetList = new HashSet<string>();

            list.Add("Plovdiv");
            list.Add("Sofia");
            list.Add("Pleven");
            list.Add("Plovdiv");
            list.Remove("Pleven");

            Console.WriteLine(string.Join(", ", list));

            hashSetList.Add("Plovdiv");
            hashSetList.Add("Sofia");
            hashSetList.Add("Pleven");
            hashSetList.Add("Plovdiv");
            hashSetList.Remove("Pleven");

            Console.WriteLine(string.Join(", ", hashSetList));
        }
    }
}
