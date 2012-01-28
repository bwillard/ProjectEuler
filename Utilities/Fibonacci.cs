using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectEuler.Utilities
{
    class Fibonacci : IEnumerable<long>
    {
        private long m_max;
        private long m_last1 = 1;
        private long m_last2 = 1;

        public Fibonacci(long max)
        {
            m_max = max;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<long> GetEnumerator()
        {
            yield return 0;
            yield return 1;

            long next = 1;
            while (next<m_max)
            {
                yield return next;
                m_last2 = m_last1;
                m_last1 = next;
                next = m_last1 + m_last2;
            } 
        }
    }
}
