using Algorithms.Sort;
using NUnit.Framework;

namespace AlgorithmsTesting.Algorithms.Sort
{
    [TestFixture]
    public class TestMsd
    {
        [Test]
        public void SmokeTest()
        {
            var toSort = new string[]
            {
                "atari",
                "apple",
                "facebook",
                "google",
                "walmart",
                "amazon",
                "netflix",
                "microsoft",
                "linkedin",
            };

            Msd.Sort(toSort);
            
            Assert.AreEqual("amazon", toSort[0]);
            Assert.AreEqual("apple", toSort[1]);
            Assert.AreEqual("atari", toSort[2]);
            Assert.AreEqual("facebook", toSort[3]);
            Assert.AreEqual("google", toSort[4]);
            Assert.AreEqual("linkedin", toSort[5]);
            Assert.AreEqual("microsoft", toSort[6]);
            Assert.AreEqual("netflix", toSort[7]);
            Assert.AreEqual("walmart", toSort[8]);
        }
    }
}