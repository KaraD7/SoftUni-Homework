﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong numberID = ulong.Parse(Console.ReadLine());
            uint UniqueEmplNumb = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age} \nGender: {gender} \nPersonal ID: {numberID}\nUnique Employee number: {UniqueEmplNumb} ");
         

        }
    }
}
