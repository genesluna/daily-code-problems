using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeProblems.D01
{
    public static class Solution
    {
        // unperformant version O(n^2)
        public static bool Run(List<int> numberlist, int k)
        {  
            foreach (var number in numberlist)
            {
                // list search is O(n)
                if (numberlist.Any(x => x == Math.Abs(number - k)))
                {
                    return true;
                }

            }

            return false;
        }

        //More peformant version O(n)
        public static bool RunV2(List<int> numberlist, int k)
        {
            var knownNumers = new HashSet<int>();

            foreach (var number in numberlist)
            {   // hash sets search is O(1)  
                if (knownNumers.Contains(k-number))
                {
                    return true;
                }

                knownNumers.Add(number);

            }

            return false;
        }
    }
}
