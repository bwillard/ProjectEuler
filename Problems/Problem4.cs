using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem4 : IProblem
    {
        public long Run()
        {
            List<long> numbers = (new Range(1000)).Reverse().ToList();

            List<long> palindromes = new List<long>();
            long maxPalindrome = 0;

            foreach (long n1 in new Range(1000))
            {
                foreach (long n2 in new Range(1000))
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
