using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeProblems.D02
{
    public static class Solution
    {
        // unperformant version O(n^2)
        public static List<int> Run(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                var exeptI = numbers.Except(new List<int> { number });
                var product = exeptI.Aggregate((element, accumulator) => element * accumulator);

                result.Add(product);
            }

            return result;
        }

        // More peformant version O(n)
        public static int[] RunV2(int[] numbers)
        {
            var n = numbers.Length;
            var leftSide = new int[n];
            var left = 1;

            // Traverse from the left
            // if numbers = { 1, 2, 3, 4, 5 }
            // then left side would be = { 1, 1, 2, 6, 24 }
            for (int i = 0; i < n; i++)
            {
                leftSide[i] = left;
                left *= numbers[i];
            }

            var right = 1;
            var productArray = leftSide;

            // Traverse from the right
            // we would get product array = { 120, 60, 40 ,30, 24 }
            for (int i = n - 1; i >= 0; i--)
            {
                productArray[i] *= right;
                right *= numbers[i];
            }

            return productArray;
        }
    }
}
