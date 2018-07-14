using System;
using System.Linq;

namespace LargestSum
{
    public static class Kata
    {
        public static int LargestSum(int[] arr)
        {
            if (arr.Length == 0 || arr.Where(x => x < 0).ToList().Count == arr.Length)
                return 0;

            var temp = 0;
            var result = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                temp = Math.Max(arr[i], temp + arr[i]);
                result = Math.Max(temp, result);
            }

            return result;
        }
    }
}