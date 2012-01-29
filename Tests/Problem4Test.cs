
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem4Test
    {
        [Test]
        public void Sample()
        {
            IProblem p = new Problem4(100);
            Assert.AreEqual(9009, p.Run());
        }

        [Test]
        public void Problem()
        {
            IProblem p = new Problem4(1000);
            Assert.AreEqual(906609, p.Run());
        }
    }
}
