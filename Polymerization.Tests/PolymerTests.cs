using NUnit.Framework;

namespace Polymerization.Tests
{
    public class PolymerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstGrowth()
        {
            var polymer = new Polymer("NNCB");
            polymer.Grow(1);

            Assert.AreEqual(1, polymer.Growth);
            Assert.AreEqual(1, polymer.LeastCommon.Value);
            Assert.AreEqual('H', polymer.LeastCommon.Key);
        }

        [Test]
        public void FourthGrowth()
        {
            var polymer = new Polymer("NNCB");
            polymer.Grow(4);

            Assert.AreEqual(4, polymer.Growth);
            Assert.AreEqual(23, polymer.MostCommon.Value);
            Assert.AreEqual('B', polymer.MostCommon.Key);
        }
    }
}
