using System.Linq;
using Algorithms.Structure.Graphs;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestDigraph
    {
        [Test]
        public void SmokeTest()
        {
            var digraph = new Digraph();
            
            Assert.Zero(digraph.GetNeighbors(0).Count);
            Assert.Zero(digraph.GetNeighbors(1).Count);
            
            digraph.AddEdge(0, 1);
            
            Assert.AreEqual(1, digraph.GetNeighbors(0).Count);
            Assert.Zero(digraph.GetNeighbors(1).Count);
        }
        
        [Test]
        public void TestVerticesAmount()
        {
            var graph = new Digraph();
            Assert.AreEqual(0, graph.Vertices.Count);
            
            graph.AddEdge(0, 1);
            Assert.AreEqual(2, graph.Vertices.Count);
            
            graph.AddEdge(2, 5);
            Assert.AreEqual(4, graph.Vertices.Count);
        }

        [Test]
        public void TestReverse()
        {
            var digraph = new Digraph();
            
            digraph.AddEdge(0, 1);
            digraph.AddEdge(1, 2);
            
            Assert.AreEqual(1, digraph.GetNeighbors(0).Count);
            Assert.AreEqual(1, digraph.GetNeighbors(0)[0]);
            
            Assert.AreEqual(1, digraph.GetNeighbors(1).Count);
            Assert.AreEqual(2, digraph.GetNeighbors(1)[0]);
            
            Assert.Zero(digraph.GetNeighbors(2).Count);

            var reversed = digraph.Reverse();
            
            Assert.Zero(reversed.GetNeighbors(0).Count);
            
            Assert.AreEqual(1, reversed.GetNeighbors(1).Count);
            Assert.AreEqual(0, reversed.GetNeighbors(1)[0]);
            
            Assert.AreEqual(1, reversed.GetNeighbors(2).Count);
            Assert.AreEqual(1, reversed.GetNeighbors(2)[0]);
        }
    }
}