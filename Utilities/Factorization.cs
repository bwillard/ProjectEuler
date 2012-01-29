using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Utilities
{
    class Factorization : IEnumerable<Int64>
    {
        private Int64 m_number;

        public Factorization(Int64 number)
        {
            m_number = number;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Int64> GetEnumerator()
        {
            long original = m_number;
            if (m_number <= 1)
            {
                yield break;
            }
            else if (m_number <= 3)
            {
                yield return m_number;
                yield break;
            }

            Int64 sqrt = (Int64)m_number/2+1;

            foreach(Int64 prime in new Primes(sqrt))
            {
                while(m_number.IsDivisiableBy(prime))
                {
                    yield return prime;
                    m_number /=prime;
                }

                if(1 == m_number)
                {
                    yield break;
                }
            }

            if(m_number == original)
            {
                //it was prime
                yield return m_number;
            }
            else
            {
                throw new Exception("Shouldn't be here, we ran out of primes and are left with: " + m_number + " left, starting number: " + original);
            }
        }
    }
}
