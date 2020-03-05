using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Day_3
{
    class Common
    {

        public List<Point> generatePathCoordinates(string input)
        {
            // Parse the input string and convert it to a list of string vectors.
            string[] stringVectorsArray = input.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> stringVectors = stringVectorsArray.ToList<string>();

            // Extract from the list of string vectors a list of directions (represented by U, D, L and R).
            List<string> directions = stringVectors
                                        .Select(element => element.Substring(0, 1))
                                        .ToList<string>();

            // Convert this into a list of unit vectors.
            List<Vector> unitVectors = new List<Vector> { };
            
            for (int i = 0; i < directions.Count; i++)
            {
                if (directions[i] == "U")
                    unitVectors.Add(new Vector(0, 1));
                else if (directions[i] == "D")
                    unitVectors.Add(new Vector(0, -1));
                else if (directions[i] == "L")
                    unitVectors.Add(new Vector(-1, 0));
                else if (directions[i] == "R")
                    unitVectors.Add(new Vector(1, 0));
                else
                    throw new Exception("Invalid direction in input.");
            }

            // Extract from the list of string vectors a list of magnitudes.
            List<int> magnitudes = stringVectors
                                    .Select(element => element.Substring(1, (element.Length - 1)))
                                    .Select(element => int.Parse(element))
                                    .ToList<int>();

            // Create a list of unit vectors corresponding to the path the wire takes.
            List<Vector> pathVectors = new List<Vector> { };

            for (int i = 0; i < unitVectors.Count; i++)
            {
                for (int n = 1; n <= magnitudes[i]; n++)
                {
                    pathVectors.Add(unitVectors[i]);
                }
            }

            // Create a list of coordinates corresponding to the path the wire takes. This is created by sequentially applying the list of unit vectors (which was just calculated) to the origin. 
            List<Point> pathCoordinates = new List<Point> { new Point(0, 0) };

            for (int j = 0; j < pathVectors.Count; j++)
            {
                pathCoordinates.Add(Point.Add(pathCoordinates[j], pathVectors[j]));
            }

            // Return the path.
            return pathCoordinates;
        }

        public double ManhattanDistance(Point p)
        {
            return Math.Abs(p.X) + Math.Abs(p.Y);
        }

        public static void PrintList<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
