using System;
using System.Linq;
using Algorithms.Concurency.Examples;
using Algorithms.DynamicProgramming;
using Algorithms.Other;
using Algorithms.Pathfinding;
using Algorithms.RandomTests;
using Algorithms.Search;
using Algorithms.Sort;
using Algorithms.Structure;
using Algorithms.Structure.Graphs;
using Algorithms.Structure.Heap;
using Algorithms.Structure.QuadTree;
using Algorithms.Structure.Queue;
using Algorithms.Structure.Tree;
using Node = Algorithms.Structure.QuadTree.Node;
using Point = Algorithms.Structure.Point;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //new IsKindOfSorted();
            //TestHeapSort();
            
            
            
            //new BoxStackingProblem();
            //new DiceThrow();
            //new MaximumProductCutting();
            //new WordBreakProblem();
            //new CuttingRod();
            //TestMergeSort();
            //new PartitionProblem();
            //TestConvexHull();
            //TestShuffleSort();
            //new MatrixChainMultiplication();
            //TestShellSort();
            //TestInsertionSort();
            //new ShortestCommonSupersequence();
            //TestSelectionSort();
            //new BooleanParenthesizationProblem();
            //new OptimalStrategyForAGame();
            //new FindTheLongestPathInMatrixWithGivenConstraints();
            //new CountNumberOfWaysToCoverDistance();
            //new PartitionSetIntoTwoSubsets();
            //new LongestIncreasingSubsequence();
            //new LongestCommonSubsequence();
            //new BellNumbers();
            //new UniqueBinarySearchTrees();
            //new SubsetSumProblem();
            //new FloydWarshallAlgorithm();
            //new KnapsackProblem();
            //new EditDistance();
            //new CoinChange();
            //new FindNumberWithoutDuplicate();
            //TestHeap();
            //TestBinarySearchTree();
            //TestQuadTree();
            //new UglyNumbers();
            //new NumberOfWaysToFormN();
            //TestFactorial();
            //new MinimumWindow();
            //new MinCostPath();
            //new MinCostPath();
            //new BytelandianGoldCoins();
            //TestBoyerMoore();
            //TestDisjointSet();
            //new SteppingNumbers();
            //GraphFindAllPaths();
            //GraphIterativeDfs();
            //FindMotherVertexInGraph();
            //DetecteCycleInDirectedGraph();
            //new FindTheRowWithMaximumNumberOfOnes();
            //TestGraph();
            //new FindTheNumberOfIslands();
            //TestTrie();
            //TestExpressionTree();
            //TestGraphsPathfinding();
            //new MinimumSwapsToMakeToArraysIdentical();
            //new MinimumSwapsRequiredToSortAnArray();
            //TestPathfinding();
            //TestFindMedian();
            //TestSort();
            //TestRbTree();
            //TestAvlTree();
            //TestMonitor();
            //TestSemaphore();
            //TestMutex();
            //TestPriorityQueue();
            //TestLock();
            //TestFibonacci();
            //TestBinarySearch();
        }

        private static void TestHeapSort()
        {
            var array = new int[] {8, 9, 7, 6, 5, 4, 3, 2, 1};
            
            HeapSort.Sort(array);

            Console.WriteLine(string.Join(", ", array));
        }
        
        private static void TestMergeSort()
        {
            var array = new int[] {8, 9, 7, 6, 5, 4, 3, 2, 1};
            
            MergeSort.Sort(array);

            Console.WriteLine(string.Join(", ", array));
        }

        private static void TestConvexHull()
        {
            var points = new Point[]
            {
                new Point(100, 100, "A"), 
                new Point(100, 10, "B"), 
                new Point(90, 15, "C"), 
                new Point(80, 5, "D"), 
                new Point(70, 25, "E"), 
                new Point(40, 50, "G"), 
                new Point(25, 7, "F"), 
                new Point(20, 80, "H"), 
                new Point(5, 30, "I"), 
                new Point(5, 95, "J"), 
            };

            var result = ConvexHull.Find(points);

            foreach (var point in result)
            {
                Console.WriteLine(point);
            }
        }

        private static void TestShuffleSort()
        {
            var array = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1};
            
            ShuffleSort.Sort(array);

            Console.WriteLine(string.Join(", ", array));
        }

        private static void TestShellSort()
        {
            var array = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1};
            
            ShellSort.Sort(array);

            Console.WriteLine(string.Join(", ", array));
        }
        
        private static void TestInsertionSort()
        {
            var array = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1};
            
            InsertionSort.Sort(array);

            Console.WriteLine(string.Join(", ", array));
        }
        
        private static void TestSelectionSort()
        {
            var array = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1};
            
            SelectionSort.Sort(array);

            Console.WriteLine(string.Join(", ", array));
        }
        
        private static void TestQuadTree()
        {
            var center = new Quad(new Point(0, 0), new Point(8, 8));
            
            var a = new Node(new Point(1, 1), 1);
            var b = new Node(new Point(2, 5), 2);
            var c = new Node(new Point(7, 6), 3);
            
            center.Insert(a);
            center.Insert(b);
            center.Insert(c);

            Console.WriteLine("Node a "  + center.Search(new Point(1, 1)).Data);
            Console.WriteLine("Node b "  + center.Search(new Point(2, 5)).Data);
            Console.WriteLine("Node c "  + center.Search(new Point(7, 6)).Data);
            Console.WriteLine("Node None "  + center.Search(new Point(5, 5)));
        }

        private static void TestFactorial()
        {
            Console.WriteLine(1 == Factorial.CalculateRecursive(0));
            Console.WriteLine(1 == Factorial.CalculateRecursive(1));
            Console.WriteLine(2 == Factorial.CalculateRecursive(2));
            Console.WriteLine(6 == Factorial.CalculateRecursive(3));
            
            Console.WriteLine(1 == Factorial.Calculate(0));
            Console.WriteLine(1 == Factorial.Calculate(1));
            Console.WriteLine(2 == Factorial.Calculate(2));
            Console.WriteLine(6 == Factorial.Calculate(3));
        }

        private static void TestBoyerMoore()
        {
            Console.WriteLine(5 == MajorityElements.BoyerMoore(new []{ 1,3,5,5,5,5,4,1,5 }));
        }

        private static void TestDisjointSet()
        {
            var n = 5;
            
            var dus = new DisjointUnionSets(5);
                dus.Union(0, 2);
                dus.Union(4, 2);
                dus.Union(3, 1);
                
            Console.WriteLine(dus.Find(4) == dus.Find(0));
            Console.WriteLine(dus.Find(1) == dus.Find(0));
        }

        private static void GraphFindAllPaths()
        {
            var graph = new Digraph();
            
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 1);
            graph.AddEdge(1, 3);

            var results = graph.FindAllPaths(2, 3);

            foreach (var path in results)
            {
                Console.WriteLine(string.Join(",", path));
            }
        }

        private static void GraphIterativeDfs()
        {
            var graph = new Digraph();
            
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 1);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 4);
            
            var result = graph.DFS(0);
            
            Console.WriteLine(string.Join(",", result));
        }

        private static void FindMotherVertexInGraph()
        {
            var graph = new Digraph();
                graph.AddEdge(0, 1);
                graph.AddEdge(0, 2);
                graph.AddEdge(1, 3);
                graph.AddEdge(4, 1);
                graph.AddEdge(6, 4);
                graph.AddEdge(5, 6);
                graph.AddEdge(5, 2);
                graph.AddEdge(6, 0);

            Console.WriteLine(graph.FindMother());
        }

        private static void DetecteCycleInDirectedGraph()
        {
            var graph = new Digraph();
                graph.AddEdge(0, 1);
                graph.AddEdge(0, 2);
                graph.AddEdge(1, 2);
                graph.AddEdge(2, 0);
                graph.AddEdge(2, 3);
                graph.AddEdge(3, 3);
                
            Console.WriteLine(graph.IsCyclic());
        }

        private static void TestTrie()
        {
            var trie = new Trie();
                trie.Insert("lol");
                
            Console.WriteLine(trie.Search("lol"));
            Console.WriteLine(trie.Search("lo"));
            Console.WriteLine(trie.Search("notlol"));
            
            trie.Insert("todelete");
            
            Console.WriteLine(trie.Search("todelete"));
            
            trie.Remove("todelete");
            
            Console.WriteLine(trie.Search("todelete"));
            Console.WriteLine(trie.Search("lol"));
            
            trie.Insert("h");
            trie.Insert("he");
            trie.Insert("hel");
            trie.Insert("hell");
            trie.Insert("hello");

            var suggestions = trie.GetSuggestions("h");

            foreach (var suggestion in suggestions)
            {
                Console.Write(suggestion + " ");
            }
            Console.WriteLine();}

        private static void TestExpressionTree()
        {
            var tree = new ExpressionTree("ab+ef*g*-");
                tree.PrintInorder(tree.Head);
        }

        private static void TestGraphsPathfinding()
        {
            var graph = new Graph();
                graph.AddEdge(0, 1);
                graph.AddEdge(0, 3);
                graph.AddEdge(1, 2);
                graph.AddEdge(3, 4);
                graph.AddEdge(3, 7);
                graph.AddEdge(4, 5);
                graph.AddEdge(4, 6);
                graph.AddEdge(4, 7);
                graph.AddEdge(5, 6);
                graph.AddEdge(6, 7);

            foreach (var i in new GraphsPathfinding().FindPath(graph, 0, 7))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            foreach (var i in new GraphsPathfinding().FindPath(graph, 2, 6))
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void TestPathfinding()
        {
            var pathfinding = new BfsPathfinding();

            var grid = new char[][]
            {
                new char[] {'0', '*', '0', 's'},
                new char[] {'*', '0', '*', '*'},
                new char[] {'0', '*', '*', '*'},
                new char[] {'d', '*', '*', '*'},
            };
            
            Console.WriteLine(pathfinding.FindPath(grid));
            
            var grid2 = new char[][]
            {
                new char[] {'0', '*', '0', 's'},
                new char[] {'*', '0', '*', '*'},
                new char[] {'0', '*', '*', '*'},
                new char[] {'d', '0', '0', '0'},
            };
            
            Console.WriteLine(pathfinding.FindPath(grid2));
        }

        private static void TestFindMedian()
        {
            var array = new int[] {4, 5, 6, 7, 1, 2, 3, 10, 11, 12, 20, 30, 40};
            
            Console.WriteLine(Median.Median.MedianSort(array));
            
            var array2 = new int[] {4, 5, 6, 7, 1, 2, 3, 10, 11, 12, 20, 30, 40};
            
            Console.WriteLine(Median.Median.QuickSelectMedian(array2));
            
            var array3 = new int[] {4, 5, 6, 7, 1, 2, 3, 10, 11, 12, 20, 30, 40};
            
            Console.WriteLine(Median.Median.PickPivotMedian(array3));
        }

        private static void TestMonitor()
        {
            //new MonitorsSyncExample();
            new MonitorCombinedExample();
        }

        private static void TestGraph()
        {
            var graph = new Digraph();
            
            /*graph.AddEdge(5, 2);
            graph.AddEdge(5, 0);
            graph.AddEdge(4, 0);
            graph.AddEdge(4, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 1);

            var stack = graph.TopologicalSort();

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }*/
            
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            var result = graph.TransitiveClosure();

            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void TestSemaphore()
        {
            new SemaphoreExample();
        }

        private static void TestMutex()
        {
            //new LocalMutexExample();
            new TimeoutMutexExample();
        }

        private static void TestPriorityQueue()
        {
            var queue = new PriorityQueue<int>();
            
            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(0);
            queue.Enqueue(2);
            queue.Enqueue(7);
            
            Console.WriteLine(queue.ToString());
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            
            Console.WriteLine(queue.ToString());
            
            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(0);
            queue.Enqueue(2);
            queue.Enqueue(7);
            
            Console.WriteLine(queue.ToString());
        }

        private static void TestLock()
        {
            new LockExample();
        }

        private static void TestAvlTree()
        {
            var tree = new AvlTree();
                
                tree.Insert(100);
                tree.Insert(99);
                tree.Insert(101);
                tree.Insert(80);
                tree.Insert(120);
                tree.Insert(140);
                tree.Insert(150);
                tree.Insert(160);
                tree.Insert(170);
                
                tree.Print();

                tree.DeleteNode(tree.Head, 120);
                
                tree.Print();
                
            /*var binarySearchTree = new BinarySearchTree();
               
                binarySearchTree.Insert(100);
                binarySearchTree.Insert(99);
                binarySearchTree.Insert(101);
                binarySearchTree.Insert(80);
                binarySearchTree.Insert(120);
                binarySearchTree.Insert(140);
                binarySearchTree.Insert(150);
                binarySearchTree.Insert(160);
                binarySearchTree.Insert(170);
                
                binarySearchTree.Print();*/
        }

        private static void TestFibonacci()
        {
            Fibonacci.Create(0).ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine();
            Fibonacci.Create(1).ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine();
            Fibonacci.Create(2).ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine();
            Fibonacci.Create(10).ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine();
        }
        
        private static void TestSort()
        {
            var arr = new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1};

            BinarySort.Sort(arr);
            
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);                
            }
            Console.WriteLine();
            
            arr = new int[] {3, 2, 1, 9, 8, 7, 6, 5, 4 };

            QuickSort.Sort(arr);
            
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);                
            }
            Console.WriteLine();
        }

        private static void TestBinarySearch()
        {
            Console.WriteLine(2 == BinarySearch.Search(new int[] { 1,2,3,4,5 }, 3));
            Console.WriteLine(1 == BinarySearch.Search(new int[] { 1,3,4,5,6,7 }, 3));
            Console.WriteLine(2 == BinarySearch.Search(new int[] { 1,2,3,4,5,6 }, 3));
            Console.WriteLine(1 == BinarySearch.Search(new int[] { 1,2,3,4,5 }, 2));
            Console.WriteLine(1 == BinarySearch.Search(new int[] { 1,2,3,4,5,6 }, 2));
            Console.WriteLine(4 == BinarySearch.Search(new int[] { 1,2,3,4,5 }, 5));
            Console.WriteLine(4 == BinarySearch.Search(new int[] { 1,2,3,4,5,6 }, 5));
            Console.WriteLine(0 == BinarySearch.Search(new int[] { 1,2,3,4,5,6 }, 1));
            Console.WriteLine(-1 == BinarySearch.Search(new int[] { }, 3));
            Console.WriteLine(-1 == BinarySearch.Search(new int[] { 1 }, 3));
            Console.WriteLine(0 == BinarySearch.Search(new int[] { 1 }, 1));
        }
    }
}