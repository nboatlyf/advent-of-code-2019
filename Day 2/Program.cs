using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Day 2");
            Console.WriteLine("=====");
            Console.WriteLine("\n");

            new PartOne().CalculateAnswer();
            Console.WriteLine("\n");
            
            Console.WriteLine("Part two:");
            new PartTwo().CalculateAnswer();

            Console.ReadKey();
        }
    }
}
