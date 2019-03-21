using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeProblems.D01
{
    public static class Solution
    {
        public static bool Run(List<int> numberlist, int k)
        {  
            foreach (var number in numberlist)
            {
                if (numberlist.Any(x => x == Math.Abs(number - k)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
