﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DailyCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = D02.Solution.RunV2(new int[] { 1, 2, 3, 4, 5 });

            Console.WriteLine(JsonConvert.SerializeObject(response));
        }
    }
}
