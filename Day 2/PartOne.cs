using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_2
{
    class PartOne : Common
    {

        public void CalculateAnswer()
        {
            // Import program and convert to int list.
            string input = File.ReadAllText(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 2\PartOne input.txt");
            string[] gravityAssistProgramAsStringArray = input.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            var gravityAssistProgramAsIntArray = Array.ConvertAll(gravityAssistProgramAsStringArray, x => int.Parse(x));
            var gravityAssistProgram = gravityAssistProgramAsIntArray.OfType<int>().ToList();
            
            // Edit some values of the program (as required by the problem).
            gravityAssistProgram[1] = 12;
            gravityAssistProgram[2] = 2;

            // Run the progam.
            ExecuteIntCode(gravityAssistProgram);

            // Find the integer at position 0 of the program, after it's been run.
            int answer = gravityAssistProgram[0];
            Console.WriteLine($"The answer to part one is {answer}");
        }
    }
}
