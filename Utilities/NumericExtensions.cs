using System;
namespace ProjectEuler.Utilities
{
    static class NumericExtensions
    {
        public static bool IsDivisiableBy(this int value, int divisor)
        {
            int n = value / divisor;
            return n * divisor == value;
        }

        public static bool IsDivisiableBy(this long value, long divisor)
        {
            Int64 n = value / divisor;
            return n * divisor == value;
        }
    }
}
