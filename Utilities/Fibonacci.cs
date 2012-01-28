using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectEuler.Utilities
{
    class Fibonacci : IEnumerable<int>
    {
        private int m_max;
        private int m_last1=1;
        private int m_last2=1;

        public Fibonacci(int max)
        {
            m_max = max;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return 0;
            yield return 1;

            int next = 1;
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
