using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeProblems.D03
{
    public static class Solution
    {
        // Time O(n log n), constant space O(1)
        public static int Run(int[] input)
        {
            input = input.Distinct().ToArray();

            Array.Sort(input);

            var n = input.Length;

            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    return (input[i] + 1);
                

                if ((input[i] + 1) > 0 && (input[i] + 1) != input[i + 1])
                    return (input[i] + 1);
            }

            return -1;
        }

        // O(n) time and space
        public static int RunV2(int[] input)
        {
            var hash = new HashSet<int>(input);

            var i = 1;

            while (hash.Contains(i))
            {
                i++;
            }

            return i;
        }

        // Time O(n), constant space O(1) as demanded by the problem
        public static int RunV3(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                while (input[i] != i + 1 && input[i] > 0 && input[i] <= input.Length)
                {
                    var holder = input[i];

                    (input[i], input[holder - 1]) = (input[holder - 1], holder);

                    if (input[i] == input[holder - 1])
                    {
                        break;
                    }
                }
            }

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i -1] != i) return i;
            }

            return input.Length + 1;
        }

    }
}
