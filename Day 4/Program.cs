using System;
using System.Collections.Generic;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 4");
            Console.WriteLine("=====");
            Console.WriteLine("\n");

            var validNumbers = new ProcessInput().CreateListOfNumbersAsDigits(125730, 579381);

            new PartOne().Calculate(validNumbers);
            new PartTwo().Calculate(validNumbers);

            Console.ReadKey();
        }
    }
}
