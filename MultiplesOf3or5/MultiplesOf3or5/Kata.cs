using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3or5
{
    public class Kata
    {
        public static int Solution(int value)
        {
            return Enumerable.Range(1, value-1).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
