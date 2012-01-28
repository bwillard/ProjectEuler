using System;
namespace ProjectEuler.Utilities
{
    static class NumericExtensions
    {
        public static bool IsDivisiableBy(this long value, long divisor)
        {
            Int64 n = value / divisor;
            return n * divisor == value;
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
    }
}
