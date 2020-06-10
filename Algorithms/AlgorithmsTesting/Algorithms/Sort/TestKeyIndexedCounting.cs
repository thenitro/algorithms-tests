using System;
using Algorithms.Sort;
using NUnit.Framework;

namespace AlgorithmsTesting.Algorithms.Sort
{
    [TestFixture]
    public class TestKeyIndexedCounting
    {
        [Test]
        public void SmokeTest()
        {
            var arrayToSort = new[] { 'd', 'a', 'c', 'f', 'f', 'b', 'd', 'b', 'f', 'b', 'e', 'a' };

            Assert.False(IsSorted(arrayToSort));
            
            KeyIndexedCounting.Sort(arrayToSort, char.MaxValue);

            Assert.True(IsSorted(arrayToSort));
        }

        private bool IsSorted(char[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}