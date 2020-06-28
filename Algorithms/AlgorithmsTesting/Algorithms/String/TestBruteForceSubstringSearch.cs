using Algorithms.algorithms.Algorithms.String;
using NUnit.Framework;

namespace AlgorithmsTesting.Algorithms.String
{
    [TestFixture]
    public class TestBruteForceSubstringSearch
    {
        [Test]
        public void SmokeTest()
        {
            var pat = "abca";
            var txt = "qwertyabcaasdfgh";
            
            Assert.AreEqual(6, BruteForceSubstringSearch.Search(pat, txt));
        }
    }
}