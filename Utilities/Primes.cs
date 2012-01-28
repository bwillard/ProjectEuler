using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectEuler.Utilities
{
    class Primes : IEnumerable<Int64>
    {
        private long m_max;

        private List<long> m_primes = new List<long> { 2 };

        public Primes(long max)
        {
            m_max = max;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<long> GetEnumerator()
        {
            for (long i = 3; i < m_max; i += 2)
            {
                if (m_primes.TrueForAll(p => !i.IsDivisiableBy(p)))
                {
                    m_primes.Add(i);
                    yield return i;
                }
            }
        }
    }
}
