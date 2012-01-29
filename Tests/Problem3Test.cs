
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem3Test
    {
        [Test]
        public void Sample()
        {
            Problem3 p = new Problem3(13195);
            Assert.AreEqual(29, p.Run());
        }

        [Test]
        public void Problem()
        {
            Problem3 p = new Problem3(600851475143);
            Assert.AreEqual(6857, p.Run());
        }
    }
}
