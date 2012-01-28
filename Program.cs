using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblem problem = new Problem3();

            Console.WriteLine(problem.Run());
        }
    }
}
