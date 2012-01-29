
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem7Test
    {
        [Test]
        public void Sample()
        {
            IProblem p = new Problem7(6);
            Assert.AreEqual(13, p.Run());
        }

        [Test]
        public void Problem()
        {
            IProblem p = new Problem7(10001);
            Assert.AreEqual(104743, p.Run());
        }
    }
}
