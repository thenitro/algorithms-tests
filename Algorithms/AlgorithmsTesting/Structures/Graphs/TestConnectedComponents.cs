using Algorithms.Structure.Graphs;
using Algorithms.Structure.Graphs.Utils;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestConnectedComponents
    {
        [Test]
        public void SmokeTest()
        {
            var graph = new Graph();
            
                graph.AddEdge(0, 1);
                graph.AddEdge(0, 2);
                graph.AddEdge(0, 3);
                graph.AddEdge(0, 4);
                
                graph.AddEdge(5, 6);
                graph.AddEdge(5, 7);
                graph.AddEdge(5, 8);
                graph.AddEdge(5, 9);
                
                graph.AddEdge(10, 11);
                graph.AddEdge(12, 13);
                graph.AddEdge(14, 15);
                
            var cc = new ConnectedComponents(graph);
            
            Assert.AreEqual(5, cc.Count);
            Assert.AreEqual(-1, cc.GetId(999));
            
            Assert.AreEqual(0, cc.GetId(0));
            Assert.AreEqual(0, cc.GetId(1));
            Assert.AreEqual(0, cc.GetId(2));
            Assert.AreEqual(0, cc.GetId(3));
            Assert.AreEqual(0, cc.GetId(4));
            
            Assert.AreEqual(1, cc.GetId(5));
            Assert.AreEqual(1, cc.GetId(6));
            Assert.AreEqual(1, cc.GetId(7));
            Assert.AreEqual(1, cc.GetId(8));
            Assert.AreEqual(1, cc.GetId(9));
            
            Assert.AreEqual(2, cc.GetId(10));
            Assert.AreEqual(2, cc.GetId(11));
            
            Assert.AreEqual(3, cc.GetId(12));
            Assert.AreEqual(3, cc.GetId(13));
            
            Assert.AreEqual(4, cc.GetId(14));
            Assert.AreEqual(4, cc.GetId(15));
        }
    }
}