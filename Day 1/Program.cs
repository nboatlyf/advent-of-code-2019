using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 1");
            Console.WriteLine("=====");
            Console.WriteLine("\n");

            new PartOne().Calculate();
            new PartTwo().Calculate();

            Console.ReadKey();
        }
    }
}
