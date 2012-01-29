
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem5Test
    {
        [Test]
        public void Sample()
        {
            IProblem p = new Problem5(10);
            Assert.AreEqual(2520, p.Run());
        }

        [Test]
        public void Problem()
        {
            IProblem p = new Problem5(20);
            Assert.AreEqual(232792560, p.Run());
        }
    }
}
