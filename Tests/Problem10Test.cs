
using NUnit.Framework;
using ProjectEuler.Problems;
namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Problem10Test
    {
        [Test]
        public void Sample()
        {
            //3^2 + 4^2 = 5^2
            IProblem p = new Problem10(10);
            Assert.AreEqual(17, p.Run());
        }

        [Test]
        public void Problem()
        {
            IProblem p = new Problem10(2000000);
            Assert.AreEqual(142913828922, p.Run());
        }
    }
}
