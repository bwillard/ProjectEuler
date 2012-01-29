using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem4 : IProblem
    {
        private long m_max;

        public Problem4(long max)
        {
            m_max = max;
        }

        public long Run()
        {
            List<long> palindromes = new List<long>();
            long maxPalindrome = 0;

            foreach (long n1 in new Range(m_max))
            {
                foreach (long n2 in new Range(m_max))
                {
                    long product = n1*n2;
                    if (product.IsPalindrome())
                    {
                        if (product > maxPalindrome)
                        {
                            maxPalindrome = product;
                        }
                    }
                }
            }

            return maxPalindrome;
        }

    }
}
