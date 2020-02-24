using System;
using System.IO;
using System.Linq;

namespace Day_1
{
    class PartOne : Common
    {
        public void Calculate()
        {

            int fuelRequired = Method1();
            //int fuelRequired = Method2();

            Console.WriteLine($"The answer to part one is {fuelRequired}.");
        }

        private int Method1()
        {
            var inputs = File.ReadAllLines(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 1\input.txt");
            var fuelRequired = 0;

            foreach (var m in inputs)
            {
                var mass = int.Parse(m);
                fuelRequired += calculateFuel(mass);
            }
            
            return fuelRequired;
        }

        private int Method2()
        {
            int fuelRequired = 
                File.ReadAllLines(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 1\input.txt")
                .Select(m => calculateFuel(int.Parse(m)))
                .Sum();

            return fuelRequired;
        }
    }

}
