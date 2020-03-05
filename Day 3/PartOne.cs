using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Day_3
{
    class PartOne : Common
    {

        public void Calculate()
        {

            // Convert strings from input file into coordinate paths.
            string[] input = File.ReadAllLines(@"C:\Users\SamSee\source\repos\advent-of-code-2019\Day 3\PartOne input.txt");
            List<Point> path0 = generatePathCoordinates(input[0]);
            List<Point> path1 = generatePathCoordinates(input[1]);

            // Find the intersection
            var intersections = path0.Intersect(path1);

            List<Tuple<Point, double>> intersectionsWithManhattanDistances = new List<Tuple<Point, double>> { };

            foreach (Point intersection in intersections)
            {
                intersectionsWithManhattanDistances.Add(new Tuple<Point, double>(intersection, ManhattanDistance(intersection)));
            }

            var intersectionsWithManhattanDistancesOrdered = intersectionsWithManhattanDistances
                                                                .OrderBy(tuple => tuple.Item2)
                                                                .ToList();

            double smallestNonZeroManhattanDistance = intersectionsWithManhattanDistancesOrdered
                                                        .Where(tuple => tuple.Item2 != 0)
                                                        .First()
                                                        .Item2;

            Console.WriteLine($"The answer to part one is {smallestNonZeroManhattanDistance}.");

            var intersectionsWithSmallestNonZeroManhattanDistance = intersectionsWithManhattanDistancesOrdered
                                                                    .Where(tuple => tuple.Item2 == smallestNonZeroManhattanDistance)
                                                                    .OrderBy(tuple => tuple.Item1.Y)
                                                                    .OrderBy(tuple => tuple.Item1.X)
                                                                    .ToList();

            

        }

    }

}
