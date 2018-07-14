using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingTermInArithmeticProgression
{
    public class Kata
    {
        public static int FindMissingTerm(int[] array)
        {
            return ((array.First() + array.Last()) * (array.Length+1) / 2)-array.Sum();
        }
    }
}
