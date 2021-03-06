﻿using Algorithms.Structure.Graphs;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Graphs
{
    [TestFixture]
    public class TestGraph
    {
        [Test]
        public void SmokeTest()
        {
            var digraph = new Graph();
            
            Assert.Zero(digraph.GetNeighbors(0).Count);
            Assert.Zero(digraph.GetNeighbors(0).Count);
            
            digraph.AddEdge(0, 1);
            
            Assert.AreEqual(1, digraph.GetNeighbors(0).Count);
            Assert.AreEqual(1, digraph.GetNeighbors(1).Count);
        }
        
        [Test]
        public void TestVerticesAmount()
        {
            var graph = new Graph();
            Assert.AreEqual(0, graph.Vertices.Count);
            
            graph.AddEdge(0, 1);
            Assert.AreEqual(2, graph.Vertices.Count);
            
            graph.AddEdge(2, 5);
            Assert.AreEqual(4, graph.Vertices.Count);
        }
    }
}