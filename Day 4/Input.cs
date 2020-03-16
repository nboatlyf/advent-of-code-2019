using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class ProcessInput
    {
        public List<NumberAsDigits> CreateListOfNumbersAsDigits(int lowerBound, int upperBound)
        {
            var integersAsDigits = new List<NumberAsDigits> { };

            for (int i = lowerBound; i <= upperBound; i++)
            {
                char[] asCharArray = i.ToString().ToCharArray();
                int[] asIntArray = Array.ConvertAll(asCharArray, x => (int)Char.GetNumericValue(x));
                NumberAsDigits asDigits = new NumberAsDigits(asIntArray);
                integersAsDigits.Add(asDigits);
            }

            return integersAsDigits;
        }
    }
}
