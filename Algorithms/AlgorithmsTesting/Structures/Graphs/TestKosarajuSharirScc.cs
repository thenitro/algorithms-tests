using Algorithms.algorithms.Structures.Graph.Utils;
using Algorithms.Structure.Graphs;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestKosarajuSharirScc
    {
        [Test]
        public void SmokeTest()
        {
            var digraph = new Digraph();
            
                digraph.AddEdge(0, 1);
                digraph.AddEdge(2, 0);
                digraph.AddEdge(0, 3);
                digraph.AddEdge(3, 2);
                digraph.AddEdge(5, 3);
                digraph.AddEdge(5, 4);

            var scc = new KosarajuSharirScc(digraph);
            
            Assert.False(scc.IsStronglyConnected(0, 1));
            
            Assert.True(scc.IsStronglyConnected(0, 2));
            Assert.True(scc.IsStronglyConnected(0, 3));
            Assert.True(scc.IsStronglyConnected(2, 3));
            
            Assert.False(scc.IsStronglyConnected(5, 3));
            Assert.False(scc.IsStronglyConnected(5, 4));
        }
    }
}