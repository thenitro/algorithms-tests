using Algorithms.algorithms.Structures.Graph.Weighted;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestEdgeWeightedGraph
    {
        [Test]
        public void SmokeTest()
        {
            var edge1 = new Edge(1, 2, 1);
            var edge2 = new Edge(1, 3, 2);
            var edge3 = new Edge(1, 4, 3);
            var edge4 = new Edge(2, 3, 4);
            var edge5 = new Edge(2, 4, 5);
            
            var graph = new EdgeWeightedGraph();
                graph.AddEdge(edge1);
                graph.AddEdge(edge2);
                graph.AddEdge(edge3);
                graph.AddEdge(edge4);
                graph.AddEdge(edge5);

            var adjacentTo1 = graph.Adjacent(1);
            Assert.AreEqual(3, adjacentTo1.Length);
            Assert.AreEqual(edge1, adjacentTo1[0]);
            Assert.AreEqual(edge2, adjacentTo1[1]);
            Assert.AreEqual(edge3, adjacentTo1[2]);
            
            var adjacentTo2 = graph.Adjacent(2);
            Assert.AreEqual(3, adjacentTo2.Length);
            Assert.AreEqual(edge1, adjacentTo2[0]);
            Assert.AreEqual(edge4, adjacentTo2[1]);
            Assert.AreEqual(edge5, adjacentTo2[2]);
        }
    }
}