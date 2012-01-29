
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem1Test
    {
        [Test]
        public void Sample()
        {
            Problem1 p1 = new Problem1(10);
            Assert.AreEqual(23, p1.Run());
        }

        [Test]
        public void Problem()
        {
            Problem1 p1 = new Problem1(1000);
            Assert.AreEqual(233168, p1.Run());
        }
    }
}
