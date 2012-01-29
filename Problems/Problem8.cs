using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem8 : IProblem
    {
        private string m_number;
        private int m_lengthOfConsecutiveDigits;

        public Problem8(string number,int lengthOfConsecutiveDigits)
        {
            m_number = number;
            m_lengthOfConsecutiveDigits = lengthOfConsecutiveDigits;
        }

        public long Run()
        {
            List<int> numbers = m_number.ToCharArray().Select(c => int.Parse(c.ToString())).ToList();

            long max =0;
            for (int i = 0; i < numbers.Count-m_lengthOfConsecutiveDigits; i++)
            {
                long product = numbers.Skip(i).Take(m_lengthOfConsecutiveDigits).Product();

                if (product > max)
                {
                    max = product;
                }

            }

            return max;
        }

    }
}
