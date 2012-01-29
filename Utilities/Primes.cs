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
            if (m_max < 2)
            {
                yield break;
            }

            yield return 2;

            for (long i = 3; i <= m_max; i += 2)
            {
                double sqrt = Math.Sqrt(i);
                bool isPrime = true;
                foreach (long prime in m_primes)
                {
                    if (prime > sqrt)
                    {
                        break;
                    }
                    else
                    {
                        if(i.IsDivisiableBy(prime))
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    m_primes.Add(i);
                    yield return i;
                }
            }
        }
    }
}
    