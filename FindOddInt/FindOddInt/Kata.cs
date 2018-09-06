using System.Linq;

namespace FindOddInt
{
    public class Kata
    {
        public int GetOddInt(int[] input)
        {
            return input.GroupBy(m => m).First(m => m.Count() % 2 == 1).Key;
        }
    }
}