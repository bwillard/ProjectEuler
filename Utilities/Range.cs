﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace ProjectEuler.Utilities
{
    class Range: IEnumerable<long>
    {
        private long m_max;

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
