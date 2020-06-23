using Algorithms.Structure.Tree.TernarySearchTrie;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Tries
{
    [TestFixture]
    public class TestTernarySearchTrie
    {
        [Test]
        public void SmokeTest()
        {
            var trie = new Tst<int>();
                trie.Put("one", 1);
                trie.Put("two", 2);
                trie.Put("three", 3);
                trie.Put("four", 4);
                trie.Put("five", 5);
                
            Assert.AreEqual(1, trie.Get("one"));
            Assert.AreEqual(2, trie.Get("two"));
            Assert.AreEqual(3, trie.Get("three"));
            Assert.AreEqual(4, trie.Get("four"));
            Assert.AreEqual(5, trie.Get("five"));
            
            Assert.False(trie.Contains("six"));
        }
    }
}