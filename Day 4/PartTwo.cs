using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day_4
{
    class PartTwo : NumberAsDigits
    {
        public void Calculate()
        {

            var integersAsDigits = new List<NumberAsDigits> { };

            for (int i = 125730; i <= 579381; i++)
            {
                char[] asCharArray = i.ToString().ToCharArray();
                int[] asIntArray = Array.ConvertAll(asCharArray, x => (int)Char.GetNumericValue(x));
                NumberAsDigits asDigits = new NumberAsDigits(asIntArray);
                integersAsDigits.Add(asDigits);
            }

            var validPasswords = integersAsDigits
                .Where(x => x.Has2OrMoreConsecutiveEqualDigits())
                .Where(x => x.AreDigitsNonDecreasing())
                .Where(x => (!(x.Has3OrMoreConsecutiveEqualDigits()) || (x.HasSequenceOfExactly2ConsecutiveEqualDigits())));

            int validPasswordsCount = validPasswords.Count();

            Console.WriteLine($"The answer to part two is {validPasswordsCount}.");

        }

    }
}
