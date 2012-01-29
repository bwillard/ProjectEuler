using ProjectEuler.Utilities;
using System.Linq;
using System;

namespace ProjectEuler.Problems
{
    class Problem3 : IProblem
    {
        private long m_number;

        public Problem3(long number)
        {
            m_number = number;
        }

        public long Run()
        {
            return new Factorization(m_number).Max();
        }

    }
}
