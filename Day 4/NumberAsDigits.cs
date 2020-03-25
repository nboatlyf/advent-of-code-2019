using System.Collections.Generic;
using System.Text;
using System.Linq;
using static System.Char;

namespace Day_4
{
    class NumberAsDigits
    {

        private int[] Digits { get; }
        private int NumberOfDigits => Digits.Length;
        public int Value => originalNumber;
        private readonly int originalNumber;

        public NumberAsDigits(int input)
        {
            originalNumber = input;

            Digits = input
                .ToString()
                .ToCharArray()
                .Select(x => (int)GetNumericValue(x))
                .ToArray();
        }

        // Checks if there are any sequences of repeated digits of length 2 or more.
        public bool Has2OrMoreConsecutiveEqualDigits()
        {
            for (int p = 0; p < NumberOfDigits - 1; p++)
            {
                if (Digits[p] == Digits[p + 1])
                {
                    return true;
                }
            }
            
            return false;
        }

        // Checks if there is at least one sequence of repeated digits of length exactly 2.
        public bool HasSequenceOfExactly2ConsecutiveEqualDigits()
        {
            // Checking the first pair of digits.
            if ((Digits[0] == Digits[1])
                && (Digits[1] != Digits[2]))
            {
                return true;
            }
            // Checking the last pairs of digits.
            else if ((Digits[NumberOfDigits - 3] != Digits[NumberOfDigits - 2])
                && (Digits[NumberOfDigits - 2] == Digits[NumberOfDigits - 1]))
            {
                return true;
            }
            // Checking all pairs of digits in the middle of the number.
            else
            {
                for (int p = 1; p < NumberOfDigits - 2; p++)
                {
                    if ((Digits[p] == Digits[p + 1])
                        & (Digits[p] != Digits[p - 1])
                        & (Digits[p + 1] != Digits[p + 2]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Checks if the digits are weakly increasing (i.e. non-decreasing).
        public bool AreDigitsWeaklyIncreasing()
        {
            for (int p = 0; p < NumberOfDigits - 1; p++)
            {
                if (Digits[p] > Digits[p + 1])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
