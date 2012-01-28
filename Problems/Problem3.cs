using ProjectEuler.Utilities;
using System.Linq;
using System;

namespace ProjectEuler.Problems
{
    class Problem3 : IProblem
    {
        public long Run()
        {
            return new Factorization(600851475143).Max();
        }

    }
}
