using Algorithms.Sort;
using NUnit.Framework;

namespace AlgorithmsTesting.Algorithms.Sort
{
    [TestFixture]
    public class TestLsd
    {
        [Test]
        public void SmokeTest()
        {
            var toSort = new string[]
            {
                "atari",
                "apple",
                "faceb",
                "googl",
                "walma",
                "amazo",
                "netfl",
                "micro",
                "linke",
            };

            Lsd.Sort(toSort);
            
            Assert.AreEqual("amazo", toSort[0]);
            Assert.AreEqual("apple", toSort[1]);
            Assert.AreEqual("atari", toSort[2]);
            Assert.AreEqual("faceb", toSort[3]);
            Assert.AreEqual("googl", toSort[4]);
            Assert.AreEqual("linke", toSort[5]);
            Assert.AreEqual("micro", toSort[6]);
            Assert.AreEqual("netfl", toSort[7]);
            Assert.AreEqual("walma", toSort[8]);
        }
    }
}