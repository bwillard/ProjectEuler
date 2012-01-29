
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem9Test
    {
        [Test]
        public void Sample()
        {
            //3^2 + 4^2 = 5^2
            IProblem p = new Problem9(12);
            Assert.AreEqual(60, p.Run());
        }

        [Test]
        public void Problem()
        {
            IProblem p = new Problem9(1000);
            Assert.AreEqual(31875000, p.Run());
        }
    }
}
