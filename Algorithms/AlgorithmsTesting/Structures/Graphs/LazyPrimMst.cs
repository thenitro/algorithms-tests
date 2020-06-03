using Algorithms.algorithms.Structures.Graph.Utils.Weighted;
using Algorithms.algorithms.Structures.Graph.Weighted;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestLazyPrimMst
    {
        [Test]
        public void SmokeTest()
        {
            var edge1 = new Edge(0, 7, 0.16);
            var edge2 = new Edge(2, 3, 0.17);
            var edge3 = new Edge(1, 7, 0.19);
            var edge4 = new Edge(0, 2, 0.26);
            var edge5 = new Edge(5, 7, 0.28);
            var edge6 = new Edge(1, 3, 0.29);
            var edge7 = new Edge(1, 5, 0.32);
            var edge8 = new Edge(4, 5, 0.35);
            var edge9 = new Edge(1, 2, 0.36);
            var edge10 = new Edge(0, 4, 0.37);
            var edge11 = new Edge(0, 4, 0.38);
            var edge12 = new Edge(6, 2, 0.4);
            var edge13 = new Edge(3, 6, 0.52);
            
            var graph = new EdgeWeightedGraph();
                graph.AddEdge(edge1);
                graph.AddEdge(edge2);
                graph.AddEdge(edge3);
                graph.AddEdge(edge4);
                graph.AddEdge(edge5);
                graph.AddEdge(edge6);
                graph.AddEdge(edge7);
                graph.AddEdge(edge8);
                graph.AddEdge(edge9);
                graph.AddEdge(edge10);
                graph.AddEdge(edge11);
                graph.AddEdge(edge12);
                graph.AddEdge(edge13);
            
            var mst = new LazyPrimMst(graph).Edges();
            
            Assert.AreEqual(7, mst.Length);
            Assert.AreEqual(edge1, mst[0]);
            Assert.AreEqual(edge3, mst[1]);
            Assert.AreEqual(edge4, mst[2]);
            Assert.AreEqual(edge2, mst[3]);
            Assert.AreEqual(edge5, mst[4]);
            Assert.AreEqual(edge8, mst[5]);
            Assert.AreEqual(edge12, mst[6]);
        }
    }
}