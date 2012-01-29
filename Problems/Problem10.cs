using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem10 : IProblem
    {
        private long m_primesLessThan;

        public Problem10(long primesLessThan)
        {
            m_primesLessThan = primesLessThan;
        }

        public long Run()
        {
            return new Primes(m_primesLessThan).Sum();
        }

    }
}
