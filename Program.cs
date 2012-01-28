using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblem problem = new Problem4();

            Console.WriteLine(problem.Run());
        }
    }
}
