using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Day_3
{
    class PartTwo : Common
    {

        public void Calculate()
        {

            // Convert strings from input file into indexed coordinate paths.
            string[] input = File.ReadAllLines(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 3\PartOne input.txt");
            
            List<Point> path0 = generatePathCoordinates(input[0]);
            List<Point> path1 = generatePathCoordinates(input[1]);

            List<CoordinateWithIndex> path0WithIndex = AddIndexToPath(path0);
            List<CoordinateWithIndex> path1WithIndex = AddIndexToPath(path1);

            var intersections = path0WithIndex
                                    .Join(path1WithIndex 
                                        ,element0 => element0.Coordinate
                                        ,element1 => element1.Coordinate
                                        ,(element0, element1) => new { coordinate = element0.Coordinate, index0 = element0.Index, index1 = element1.Index, indexSum = element0.Index + element1.Index })
                                    .ToList();

            var distinctIndexSums = intersections
                                .Select(element => element.indexSum)
                                .Distinct()
                                .ToList();

            int smallestNonTrivialIndexSum = distinctIndexSums
                                                .Where(sum => sum != 0)
                                                .OrderBy(sum => sum)
                                                .First();

            Console.WriteLine($"The answer to part two is {smallestNonTrivialIndexSum}.");

            // In case you want to find all the points with the smallest non-trivial index sum:

            var earliestNonTrivialIntersections = intersections
                                                    .Where(element => element.indexSum == smallestNonTrivialIndexSum)
                                                    .OrderBy(element => element.index1)
                                                    .OrderBy(element => element.index0)
                                                    .ToList();
            
            for (int i = 0; i < earliestNonTrivialIntersections.Count; i++)
            {
                Console.WriteLine($"({earliestNonTrivialIntersections[i].coordinate}): reached after {earliestNonTrivialIntersections[i].index0} path0 steps and {earliestNonTrivialIntersections[i].index1} path1 steps. Sum of steps = {smallestNonTrivialIndexSum}.");
            }


        }

        public List<CoordinateWithIndex> AddIndexToPath(List<Point> path)
        {
            List<CoordinateWithIndex> pathWithIndex = new List<CoordinateWithIndex>() { };

            for (int index = 0; index < path.Count; index++)
            {
                pathWithIndex.Add(new CoordinateWithIndex(path[index], index));
            }

            return pathWithIndex;
        }
    }

    class CoordinateWithIndex
    {

        public Point Coordinate { get; set; }
        public int Index { get; set; }

        public CoordinateWithIndex(Point coordinate, int index)
        {
            Coordinate = coordinate;
            Index = index;
        }

    }

}
