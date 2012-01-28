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
            Int64 sqrt = (Int64)Math.Sqrt(m_number);

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

            throw new Exception("Shouldn't be here, we ran out of primes and are left with: " + m_number);
        }
    }
}
