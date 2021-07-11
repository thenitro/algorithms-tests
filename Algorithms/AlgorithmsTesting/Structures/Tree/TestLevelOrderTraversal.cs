using System;
using Algorithms.Structure.Tree;
using Algorithms.Structure.Tree.Abstract;
using NUnit.Framework;

namespace AlgorithmsTesting.Structures.Trees
{
    [TestFixture]
    public class TestLevelOrderTraversal
    {
        [Test]
        public void SmokeTest()
        {
            var tree = new AbstractBinaryTree();
                tree.Root = new BinaryTreeNode<IComparable>()
            {
                Value = 1,
                Left = new BinaryTreeNode<IComparable>()
                {
                    Value = 2,
                    Left = new BinaryTreeNode<IComparable>()
                    {
                        Value = 4
                    },
                    Right = new BinaryTreeNode<IComparable>()
                    {
                        Value = 5
                    }
                },
                Right = new BinaryTreeNode<IComparable>()
                {
                    Value = 3,
                },
            };
            
            var result = tree.GetLevelOrderTraversal();
            
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(1, result[0].Value);
            Assert.AreEqual(2, result[1].Value);
            Assert.AreEqual(3, result[2].Value);
            Assert.AreEqual(4, result[3].Value);
            Assert.AreEqual(5, result[4].Value);
        }
    }
}