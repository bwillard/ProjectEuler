
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem6Test
    {
        [Test]
        public void Sample()
        {
            IProblem p = new Problem6(10);
            Assert.AreEqual(2640, p.Run());
        }

        [Test]
        public void Problem()
        {
            IProblem p = new Problem6(100);
            Assert.AreEqual(25164150, p.Run());
        }
    }
}
