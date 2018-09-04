using System;

namespace PersistentBugger
{
    public class Kata
    {
        public long GetPersistentBugger(long input)
        {
            var arr = IntToCharArray(input);
            var count = 0;
            while (arr.Length > 1)
            {
                count++;
                arr = IntToCharArray(ReduceArray(arr));
            }
            return count;
        }

        private static int ReduceArray(char[] arr)
        {
            var i = 1;
            foreach (var item in arr)
            {
                i *= (int)Char.GetNumericValue(item);
            }

            return i;
        }

        private static char[] IntToCharArray(long input)
        {
            return input.ToString().ToCharArray();
        }
    }
}