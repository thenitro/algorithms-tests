using Algorithms.algorithms.Algorithms.String;
using NUnit.Framework;

namespace AlgorithmsTesting.Algorithms.String
{
    [TestFixture]
    public class TestLongestRepeatedSubstring
    {
        [Test]
        public void SmokeTest()
        {
            var input = "qwertyuiopqwertyasdfghjkl";
            
            var longestSubstring = LongestRepeatedSubstring.Find(input);
            
            Assert.AreEqual("qwerty", longestSubstring);
        }
    }
}