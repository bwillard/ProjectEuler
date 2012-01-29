
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem2Test
    {
        [Test]
        public void Sample()
        {
            Problem2 p = new Problem2(20);
            Assert.AreEqual(10, p.Run());
        }

        [Test]
        public void Problem()
        {
            Problem2 p = new Problem2(4000000);
            Assert.AreEqual(4613732 , p.Run());
        }
    }
}
