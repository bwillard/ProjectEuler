using ProjectEuler.Utilities;
using System.Linq;

namespace ProjectEuler.Problems
{
    class Problem1 : IProblem
    {
        public int Run()
        {
            return new Range(1000).Where(n => n.IsDivisiableBy(3) || n.IsDivisiableBy(5)).Sum();
        }

    }
}
