using System;
using System.Collections.Generic;

namespace ProjectEuler.Utilities
{
    static class NumericExtensions
    {
        public static bool IsDivisiableBy(this long value, long divisor)
        {
            return 0 == value % divisor;
        }

        public static bool IsPalindrome(this long number)
        {
            string s = number.ToString();

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i-1])
                {
                    return false;
                }
            }

            return true;
        }

        public static long Product(this IEnumerable<int> values)
        {
            long product = 1;
            foreach (int n in values)
            {
                product *= n;
            }

            return product;
        }
    }
}
