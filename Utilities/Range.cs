using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectEuler.Utilities
{
    class Range: IEnumerable<int>
    {
        private int m_max;

        public Range(int max)
        {
            m_max = max;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i < m_max; i++)
            {
                yield return i;
            }
        }
    }
}
