using System.Collections.Generic;

namespace Fibonacci
{
    //The numbers in this series are going to start with 0 and 1.
    //The next number is the sum of the previous two numbers.
    //The formula for calculating the Fibonacci Series is as follows:
    //  F(n) = F(n - 1) + F(n - 2)
    //  where:
    //      F(n) is the term number.
    //      F(n-1) is the previous term (n-1).
    //      F(n-2) is the term before that (n-2).
    public static class FibonacciCalculator
    {
        public static IEnumerable<int> CalculateFibonacciUpTo(int elementCount)
        {
            var sequence = new List<int> { 0, 1 };

            if (elementCount < 3)
            {
                return sequence;
            }

            var firstNumber = 0;
            var secondNumber = 1;

            for (int i = 0; i < elementCount - 2; i++)
            {
                var nextElement = firstNumber + secondNumber;
                sequence.Add(nextElement);

                firstNumber = secondNumber;
                secondNumber = nextElement;
            }

            return sequence;
        }

        public static IEnumerable<int> CalculateFibonacciUpToAlt(int elementCount)
        {
            return CalculateFibonacciUpToAlt(elementCount, new List<int> {0, 1});
        }

        public static IEnumerable<int> CalculateFibonacciUpToAlt
            (int elementCount, List<int>? sequence = null)
        {
            var calcSequence = sequence ?? new List<int> { 0, 1 };

            if (calcSequence.Count < 2)
            {
                return calcSequence;
            }

            if (calcSequence.Count >= elementCount)
            {
                return calcSequence;
            }

            var penultimateNbr = calcSequence[^2];
            var lastNbr = calcSequence[^1];

            calcSequence.Add(penultimateNbr + lastNbr);

            return CalculateFibonacciUpToAlt(elementCount, calcSequence);
        }
    }
}