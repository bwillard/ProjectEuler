using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem6 : IProblem
    {
        private long m_max;

        public Problem6(long max)
        {
            m_max = max;
        }

        public long Run()
        {
            IEnumerable<long> range = new Range(m_max+1);

            return range.Sum() * range.Sum() - range.Select(n => n * n).Sum();
        }

    }
}
