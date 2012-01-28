namespace ProjectEuler.Utilities
{
    static class ExtensionsInt
    {
        public static bool IsDivisiableBy(this int value, int divisor)
        {
            int n = value / divisor;
            return n * divisor == value;
        }
    }
}
