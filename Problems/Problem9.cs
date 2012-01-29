using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem9 : IProblem
    {
        private long m_sum;

        public Problem9(long sum)
        {
            m_sum = sum;
        }

        public long Run()
        {
            for (int i = 1; i < m_sum / 2; i++)
            {
                for (int j = i; j < m_sum; j++)
                {
                    long product = i * i + j * j;
                    long sqrt = (long)Math.Sqrt(product);

                    if (sqrt * sqrt == product && i + j + sqrt == m_sum)
                    {
                        return i * j * sqrt;
                    }
                }
            }

            throw new Exception("Couldn't find a matching set of numbers");
        }

    }
}
