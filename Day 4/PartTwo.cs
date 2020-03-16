using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day_4
{
    class PartTwo : NumberAsDigits
    {
        public void Calculate(List<NumberAsDigits> integersAsDigits)
        {

            var validPasswords = integersAsDigits
                .Where(x => x.Has2OrMoreConsecutiveEqualDigits())
                .Where(x => x.AreDigitsNonDecreasing())
                .Where(x => (!(x.Has3OrMoreConsecutiveEqualDigits()) || (x.HasSequenceOfExactly2ConsecutiveEqualDigits())));

            int validPasswordsCount = validPasswords.Count();

            Console.WriteLine($"The answer to part two is {validPasswordsCount}.");

        }

    }
}
