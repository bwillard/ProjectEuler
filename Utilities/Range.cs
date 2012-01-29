using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectEuler.Utilities
{
    class Range: IEnumerable<long>
    {
        private long m_max;

        /// <summary>
        /// returns a set of number from 1 to max (exclusive)
        /// </summary>
        /// <param name="max">max s exclusive, e.g. it will no be returned</param>
        public Range(long max)
        {
            m_max = max;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<long> GetEnumerator()
        {
            for (long i = 1; i < m_max; i++)
            {
                yield return i;
            }
        }
    }
}
