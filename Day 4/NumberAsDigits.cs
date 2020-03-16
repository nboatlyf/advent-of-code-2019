using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class NumberAsDigits
    {

        public int[] Digits { get; }
        public int Value { get; }
        public int NumberOfDigits { get; }


        public NumberAsDigits(params int[] digits)
        {
            NumberOfDigits = digits.Length;
            Digits = new int[NumberOfDigits];
            Value = 0;

            for (int p = 0; p < NumberOfDigits; p++)
            {
                if (digits[p] < 0 || digits[p] > 9)
                    throw new ArgumentOutOfRangeException("Each digit should be an integer between 0 and 9.");
                Digits[p] = digits[(NumberOfDigits - 1) - p];
                Value += Digits[p] * (int)Math.Pow(10, p);
            }
        }

        // Checks if there are any sequences of repeated digits of length 2 or more.
        public bool Has2OrMoreConsecutiveEqualDigits()
        {
            bool returnBool = false;

            for (int p = 0; p < NumberOfDigits - 1; p++)
            {
                if (Digits[p] == Digits[p + 1])
                {
                    returnBool = true;
                    break;
                }
            }

            return returnBool;
        }
        
        // Checks if there are any sequences of repeated digits of length 3 or more.
        public bool Has3OrMoreConsecutiveEqualDigits()
        {
            bool returnBool = false;

            for (int p = 0; p < NumberOfDigits - 2; p++)
            {
                if (Digits[p] == Digits[p + 1] 
                    && Digits[p + 1] == Digits[p + 2])
                {
                    returnBool = true;
                    break;
                }
            }

            return returnBool;
        }

        // Checks if there is at least one sequence of repeated digits of length exactly 2.
        public bool HasSequenceOfExactly2ConsecutiveEqualDigits()
        {
            bool returnBool = false;

            if ((Digits[0] == Digits[1])
                && (Digits[1] != Digits[2]))
            {
                returnBool = true;
            }
            else if ((Digits[NumberOfDigits - 3] != Digits[NumberOfDigits - 2])
                && (Digits[NumberOfDigits - 2] == Digits[NumberOfDigits - 1]))
            {
                returnBool = true;
            }
            else
            {
                for (int p = 1; p < NumberOfDigits - 2; p++)
                {
                    if ((Digits[p] == Digits[p + 1])
                        & (Digits[p] != Digits[p - 1])
                        & (Digits[p + 1] != Digits[p + 2]))
                    {
                        returnBool = true;
                        break;
                    }
                }
            }

            return returnBool;
        }

        // Checks if the digits are non-decreasing (a.k.a. weakly increasing).
        public bool AreDigitsNonDecreasing()
        {
            bool returnBool = true;

            for (int p = 0; p < NumberOfDigits - 1; p++)
            {
                if (Digits[p] < Digits[p + 1])
                {
                    returnBool = false;
                    break;
                }
            }

            return returnBool;
        }

    }
}
