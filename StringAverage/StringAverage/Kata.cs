using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata
    {
        private static string _initialError = "n/a";
        private static Dictionary<string, int> strDic = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };

        public static string StringAverage(string str)
        {
            if (String.IsNullOrEmpty(str.Trim()))
            {
                return _initialError;
            };

            var numStrings = str.Split(' ');
            int sum = 0;

            foreach (string numStr in numStrings)
            {
                if (strDic.ContainsKey(numStr.ToLower()))
                    sum += strDic[numStr.ToLower()];
                else
                    return _initialError;
            };

            return strDic.FirstOrDefault(x => x.Value == (sum / numStrings.Length)).Key;
        }
    }
}
