using ProjectEuler.Utilities;
using System.Linq;

namespace ProjectEuler.Problems
{
    class Problem2 : IProblem
    {
        public int Run()
        {
            return new Fibonacci(4000000).Where(n => n.IsDivisiableBy(2)).Sum();
        }

    }
}
