using Algorithms.algorithms.Structures.Graph.Utils;
using Algorithms.Structure.Graphs;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestDepthFirstOrder
    {
        [Test]
        public void SmokeTest()
        {
            var graph = new Digraph();
                graph.AddEdge(0, 5);
                graph.AddEdge(0, 1);
                graph.AddEdge(3, 5);
                graph.AddEdge(5, 2);
                graph.AddEdge(6, 0);
                graph.AddEdge(1, 4);
                graph.AddEdge(0, 2);
                graph.AddEdge(3, 6);
                graph.AddEdge(3, 4);
                graph.AddEdge(6, 4);
                graph.AddEdge(3, 2);

            var depthFirstOrder = new DepthFirstOrder(graph);
            
            Assert.AreEqual(3, depthFirstOrder.ReversePost[0]);
            Assert.AreEqual(6, depthFirstOrder.ReversePost[1]);
            Assert.AreEqual(0, depthFirstOrder.ReversePost[2]);
            Assert.AreEqual(1, depthFirstOrder.ReversePost[3]);
            Assert.AreEqual(4, depthFirstOrder.ReversePost[4]);
            Assert.AreEqual(5, depthFirstOrder.ReversePost[5]);
            Assert.AreEqual(2, depthFirstOrder.ReversePost[6]);
        }
    }
}