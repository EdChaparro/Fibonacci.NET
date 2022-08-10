﻿using System.Collections.Generic;

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
        public static IEnumerable<int> CalculateFibonacci(int nbrOfElements)
        {
            var sequence = new List<int> { 0, 1 };

            while (sequence.Count < nbrOfElements)
            {
                var penultimateNbr = sequence[^2];
                var lastNbr = sequence[^1];

                sequence.Add(penultimateNbr + lastNbr);
            }

            return sequence;
        }
    }
}