using System;
using System.Collections.Generic;
using System.Linq;
using Fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTest
{
    [TestClass]
    public class FibonacciCalculatorTest
    {
        [TestMethod]
        public void ShouldCalculateSequenceForNumberOfElements()
        {
            ExecuteFibonacciSequenceStrategy(FibonacciCalculator.CalculateFibonacci);
        }

        public void ExecuteFibonacciSequenceStrategy(Func<int, IEnumerable<int>> strategy)
        {
            var expectedResults = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

            var calculatedResults = strategy(expectedResults.Count);

            CollectionAssert.AreEqual(expectedResults, calculatedResults.ToList());
        }
    }
}