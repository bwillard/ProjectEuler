using NUnit.Framework;
using System.Collections.Generic;
using ProjectEuler.Problems;
using ProjectEuler.Utilities;
using System.Linq;

namespace ProjectEuler.Tests.Utilities
{
    [TestFixture]
    public class FactorizationTest
    {
        [Test]
        public void Simple2()
        {
            List<long> f = new Factorization(2).ToList();
            Assert.AreEqual(1, f.Count);
            Assert.AreEqual(2, f[0]);
        }

        [Test]
        public void Simple3()
        {
            List<long> f = new Factorization(3).ToList();
            Assert.AreEqual(1, f.Count);
            Assert.AreEqual(3, f[0]);
        }

        [Test]
        public void Simple4()
        {
            List<long> f = new Factorization(4).ToList();
            Assert.AreEqual(2, f.Count);
            Assert.AreEqual(2, f[0]);
            Assert.AreEqual(2, f[1]);
        }

        [Test]
        public void Simple5()
        {
            List<long> f = new Factorization(5).ToList();
            Assert.AreEqual(1, f.Count);
            Assert.AreEqual(5, f[0]);
        }

        [Test]
        public void Simple6()
        {
            List<long> f = new Factorization(6).ToList();
            Assert.AreEqual(2, f.Count);
            Assert.AreEqual(2, f[0]);
            Assert.AreEqual(3, f[1]);
        }

        [Test]
        public void MultipleFactors1()
        {
            List<long> f = new Factorization(2*2*3*5*7*11).ToList();
            Assert.AreEqual(6, f.Count);
            Assert.AreEqual(2, f[0]);
            Assert.AreEqual(2, f[1]);
            Assert.AreEqual(3, f[2]);
            Assert.AreEqual(5, f[3]);
            Assert.AreEqual(7, f[4]);
            Assert.AreEqual(11, f[5]);
        }
    }
}
