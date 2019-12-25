using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Day1
{
    public static class Part2
    {
        public static string Execute()
        {
            var inputList = Input.AsList;

            int result = 0;

            foreach (var i in inputList)
            {
                result += RecursiveCalc(i);
            }

            return result.ToString();
        }

        private static int RecursiveCalc(int i)
        {
            var result = (int) Math.Floor(i / 3m) - 2;

            if (result > 0)
            {
                return result + RecursiveCalc(result);
            }

            return 0;
        }
    }
}
