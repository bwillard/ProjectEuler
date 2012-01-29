using ProjectEuler.Utilities;
using System.Linq;

namespace ProjectEuler.Problems
{
    class Problem1 : IProblem
    {
        private long m_below;

        public Problem1(long below)
        {
            m_below = below;
        }

        public long Run()
        {
            return new Range(m_below).Where(n => n.IsDivisiableBy(3) || n.IsDivisiableBy(5)).Sum();
        }

    }
}
