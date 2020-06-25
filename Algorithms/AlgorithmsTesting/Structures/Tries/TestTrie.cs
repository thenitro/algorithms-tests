using Algorithms.Structure.Tree;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Tries
{
    [TestFixture]
    public class TestTrie
    {
        [Test]
        public void TestKeys()
        {
            var trie = new Trie();
            
                trie.Insert("by");
                trie.Insert("sea");
                trie.Insert("sells");
                trie.Insert("she");
                trie.Insert("shells");
                trie.Insert("shore");
                trie.Insert("the");

            var keys = trie.Keys();
            
            Assert.AreEqual("by", keys[0]);
            Assert.AreEqual("sea", keys[1]);
            Assert.AreEqual("sells", keys[2]);
            Assert.AreEqual("she", keys[3]);
            Assert.AreEqual("shells", keys[4]);
            Assert.AreEqual("shore", keys[5]);
            Assert.AreEqual("the", keys[6]);
        }
        
        [Test]
        public void TestLongestPrefix()
        {
            var trie = new Trie();
            
                trie.Insert("by");
                trie.Insert("sea");
                trie.Insert("sells");
                trie.Insert("she");
                trie.Insert("shells");
                trie.Insert("shore");
                trie.Insert("the");
            
            Assert.AreEqual("shells", trie.LongestPrefixOf("shellsort"));
        }
    }
}