using Algorithms.algorithms.Structures.Graph.Weighted;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestEdge
    {
        [Test]
        public void SmokeTest()
        {
            var edge = new Edge(1, 2, 3.3);
            
            Assert.AreEqual(1, edge.Either());
            Assert.AreEqual(2, edge.Other(edge.Either()));
        }
        
        [Test]
        public void CompareTest()
        {
            var edgeA = new Edge(1, 2, 3.3);
            var edgeB = new Edge(2, 3, 5.0);
            
            Assert.AreEqual(-1, edgeA.CompareTo(edgeB));
            Assert.AreEqual(1, edgeB.CompareTo(edgeA));
            
            var edgeC = new Edge(0, 1, 3.3);
            
            Assert.AreEqual(0, edgeA.CompareTo(edgeC));
            Assert.AreEqual(0, edgeC.CompareTo(edgeA));
        }
    }
}