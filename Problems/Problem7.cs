using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem7 : IProblem
    {
        private long m_primeNumber;

        public Problem7(long primeNumber)
        {
            m_primeNumber = primeNumber;
        }

        public long Run()
        {
            IEnumerable<long> primes = new Primes(long.MaxValue);

            return primes.ElementAt((int)m_primeNumber-1);
        }

    }
}
