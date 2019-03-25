using Newtonsoft.Json;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DailyCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = D03.Solution.RunV3(new int[] { 2, 0, -1, -3, 4, 9, -9, 8, -1, 2, 7, 1, 3, 6, 6, 7, 1});

            Console.WriteLine(JsonConvert.SerializeObject(response));
        }
    }
}
