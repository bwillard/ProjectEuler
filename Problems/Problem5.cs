using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem5 : IProblem
    {
        private long m_maxDivisor;

        public Problem5(long maxDivisor)
        {
            m_maxDivisor = maxDivisor;
        }

        public long Run()
        {
            long lcm = 1;

            for (int i = 1; i <= m_maxDivisor; i++)
            {
                lcm = (new LCM(lcm, i)).Value;
            }

            return lcm;
        }

    }
}
