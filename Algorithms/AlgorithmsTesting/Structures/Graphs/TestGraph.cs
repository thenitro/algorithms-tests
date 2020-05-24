using Algorithms.Structure;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestGraph
    {
        [Test]
        public void TestVerticesAmount()
        {
            var graph = new Graph(false);
            
            Assert.AreEqual(0, graph.Vertices.Count);
            
            graph.AddEdge(0, 1);
            
            Assert.AreEqual(2, graph.Vertices.Count);
            
            graph.AddEdge(2, 5);
            
            Assert.AreEqual(4, graph.Vertices.Count);
        }
    }
}