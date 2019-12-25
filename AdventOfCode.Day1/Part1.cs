using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Day1
{
    public static class Part1
    {
        public static string Execute()
        {
            var inputList = Input.AsList;

            int result = 0;

            foreach (var i in inputList)
            {
                result += (int) Math.Floor(i / 3m) - 2;
            }

            return result.ToString();
        }
    }
}
