using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeProblems.D01
{
    public static class Solution
    {
        // Unperformant version O(n^2)
        public static bool Run(List<int> numbersList, int k)
        {  
            foreach (var number in numbersList)
            {
                // list search is O(n)
                if (numbersList.Any(x => x == k - number))
                {
                    return true;
                }

            }

            return false;
        }

        // More peformant version O(n)
        public static bool RunV2(List<int> numberlist, int k)
        {
            var knownNumbers = new HashSet<int>();

            foreach (var number in numberlist)
            {   // hash sets search is O(1)  
                if (knownNumbers.Contains(k - number))
                {
                    return true;
                }

                knownNumbers.Add(number);

            }

            return false;
        }
    }
}
