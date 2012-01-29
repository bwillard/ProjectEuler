using ProjectEuler.Utilities;
using System.Linq;

namespace ProjectEuler.Problems
{
    class Problem2 : IProblem
    {
        private long m_max;

        public Problem2(long max)
        {
            m_max = max;
        }

        public long Run()
        {
            return new Fibonacci(m_max).Where(n => n.IsDivisiableBy(2)).Sum();
        }

    }
}
