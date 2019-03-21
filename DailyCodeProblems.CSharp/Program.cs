using System;
using System.Collections.Generic;

namespace DailyCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = D01.Solution.Run(new List<int> { 10, 15, 2, 6 }, 17);
            Console.WriteLine(response);
        }
    }
}
