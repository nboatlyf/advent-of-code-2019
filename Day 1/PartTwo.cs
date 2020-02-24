using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class PartTwo : Common
    {
        public void Calculate()
        {
            var inputs = File.ReadAllLines(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 1\input.txt");
            var fuelRequired = 0;


            foreach (var m in inputs)
            {
                var mass = int.Parse(m);

                var intermediateFuelRequired = new List<int>
                {
                    calculateFuel(mass)
                };

                while (intermediateFuelRequired.Last() != 0)
                {
                    intermediateFuelRequired.Add(calculateFuel(intermediateFuelRequired.Last()));
                }

                fuelRequired += intermediateFuelRequired.Sum();

            }

            Console.WriteLine($"The answer to part two is {fuelRequired}.");
        }

    }
}
