using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day_4
{
    class PartTwo
    {
        public void Calculate(IEnumerable<NumberAsDigits> integersAsDigits)
        {

            var validPasswords = integersAsDigits
                .Where(x => x.HasSequenceOfExactly2ConsecutiveEqualDigits())
                .Where(x => x.AreDigitsWeaklyIncreasing());

            int validPasswordsCount = validPasswords.Count();

            Console.WriteLine($"The answer to part two is {validPasswordsCount}.");

        }

    }
}
