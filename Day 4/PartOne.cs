using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day_4
{
    class PartOne
    {
        public void Calculate(IEnumerable<NumberAsDigits> integersAsDigits)
        {

            var validPasswords = integersAsDigits
                .Where(x => x.Has2OrMoreConsecutiveEqualDigits())
                .Where(x => x.AreDigitsWeaklyIncreasing());

            int validPasswordsCount = validPasswords.Count();

            Console.WriteLine($"The answer to part one is {validPasswordsCount}.");

        }

    }
}
