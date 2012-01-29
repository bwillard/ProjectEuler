
using NUnit.Framework;
using ProjectEuler.Problems;
using ProjectEuler.Utilities;
namespace ProjectEuler.Tests.Utilities
{
    [TestFixture]
    public class LCMTest
    {
        [Test]
        public void Simple1()
        {
            LCM p1 = new LCM(2,3);
            Assert.AreEqual(6, p1.Value);
        }

        [Test]
        public void Simple2()
        {
            LCM p1 = new LCM(4, 3);
            Assert.AreEqual(12, p1.Value);
        }

        [Test]
        public void Simple3()
        {
            LCM p1 = new LCM(4, 6);
            Assert.AreEqual(12, p1.Value);
        }
    }
}
