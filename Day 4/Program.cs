using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 4");
            Console.WriteLine("=====");
            Console.WriteLine("\n");

            var lowerBound = int.Parse(args[0]);
            var upperBound = int.Parse(args[1]);
            var sizeOfRange = upperBound - lowerBound + 1;

            var validNumbers = Enumerable
                .Range(lowerBound, sizeOfRange)
                .Select(num => new NumberAsDigits(num));

            new PartOne().Calculate(validNumbers);
            new PartTwo().Calculate(validNumbers);

            Console.ReadKey();
        }
    }
}
