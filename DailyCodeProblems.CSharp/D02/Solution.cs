using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeProblems.D02
{
    public static class Solution
    {
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
    }
}
