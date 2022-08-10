using System.Collections.Generic;
using System.Linq;
using IntrepidProducts.Fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntrepidProducts.FibonacciTest
{
    [TestClass]
    public class FibonacciCalculatorTest
    {
        [TestMethod]
        public void ShouldCalculateSequenceForNumberOfElements()
        {
            var expectedResults = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

            var calculatedResults = FibonacciCalculator.CalculateFibonacci(expectedResults.Count);

            CollectionAssert.AreEqual(expectedResults, calculatedResults.ToList());
        }

        [TestMethod]
        public void ShouldIterateFibonacciSequence()
        {
            var expectedResults = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

            var i = 0;
            foreach (var nbr in FibonacciCalculator.FibonacciSequence(expectedResults.Count))
            {
                Assert.AreEqual(expectedResults[i++], nbr);
            }
        }
    }
}