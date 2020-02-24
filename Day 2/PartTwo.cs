using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day_2
{
    class PartTwo : Common
    {

        public void CalculateAnswer()
        {
            // Import program and convert to int list.
            string input = File.ReadAllText(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 2\PartOne input.txt");
            var gravityAssistProgram = input.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(entry => int.Parse(entry))
                .ToList();

            // Write program to output.
            /*
            for (int i = 0; i < gravityAssistProgram.Count(); i++)
            {
                Console.WriteLine(gravityAssistProgram[i]);
            }
            */

            // Declare variables which (may) get used in the following nested loop.
            int desiredOutput = 19690720;
            bool isSolutionFound = false;
            int solutionNoun = 0;
            int solutionVerb = 0;

            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    // Copy gravityAssistProgram but edit the noun and verb (addresses 1 and 2 respectively).
                    List<int> gravityAssistProgramTemp = gravityAssistProgram.ToList();
                    gravityAssistProgramTemp[1] = noun;
                    gravityAssistProgramTemp[2] = verb;

                    // Execute the program.
                    ExecuteIntCode(gravityAssistProgramTemp);
                   
                    // Check if the output is equal to the desired value. Update the solution variables if it is.
                    if (gravityAssistProgramTemp[0] == desiredOutput)
                    {
                        isSolutionFound = true;
                        solutionNoun = noun;
                        solutionVerb = verb;
                        break;
                    }
                }
            }

            int answer = (100 * solutionNoun) + solutionVerb;

            if (isSolutionFound == true)
            {
                Console.WriteLine($"The noun in the range 0-99 (inclusive) which produces the output {desiredOutput} is {solutionNoun}.");
                Console.WriteLine($"The verb in the range 0-99 (inclusive) which produces the output {desiredOutput} is {solutionVerb}.");
                Console.WriteLine($"(100 * noun) + verb = (100 * {solutionNoun}) + {solutionVerb} = {answer}.");
            }
            else
            {
                Console.WriteLine($"No noun and verb combination (with both in the range 0-99 inclusive) exists which produces the output {desiredOutput}.");
            }
        }
    }
}
