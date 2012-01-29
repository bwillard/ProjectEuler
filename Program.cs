using System;
using System.Linq;
using ProjectEuler.Problems;
using ProjectEuler.Utilities;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            Problem5 lcm = new Problem5(6);
            Console.WriteLine(1 * 2 * 3 * (2) * 5);
            Console.WriteLine(lcm.Run());
        }
    }
}
