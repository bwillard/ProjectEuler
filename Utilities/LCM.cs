using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Utilities
{
    class LCM
    {
        public LCM(long n1, long n2):this(new Factorization(n1),new Factorization(n2))
        {

        }

        public LCM(IEnumerable<long> factorization1, IEnumerable<long> factorization2)
        {
            Dictionary<long, int> factorCount = CountFactors(factorization1);

            Value = 1;

            foreach (KeyValuePair<long, int> pair in factorCount)
            {
                Value *= (Int64)Math.Pow(pair.Key, pair.Value);
            }


            foreach (KeyValuePair<long,int> pair in CountFactors(factorization2))
            {
                if (factorCount.ContainsKey(pair.Key))
                {
                    if(pair.Value > factorCount[pair.Key])
                    {
                        Value *= (Int64)Math.Pow(pair.Key, pair.Value - factorCount[pair.Key]);
                    }
                }
                else
                {
                    Value *= (Int64)Math.Pow(pair.Key, pair.Value);
                }
            }
        }

        private Dictionary<long, int> CountFactors(IEnumerable<long> factorization)
        {
            Dictionary<long, int> factorCount = new Dictionary<long, int>();

            foreach(long factor in factorization)
            {
                if (factorCount.ContainsKey(factor))
                {
                    factorCount[factor]++;
                }
                else
                {
                    factorCount[factor] = 1;
                }
            }

            return factorCount;
        }

        public long Value { get; private set; }
    }
}
