using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestRankNumber
{
    public class Kata
    {
        public static int HighestRank(List<int> array)
        {
            return array.GroupBy(x => x).OrderByDescending(x => x.Count()).ToList().First().Key;
        }
    }
}
