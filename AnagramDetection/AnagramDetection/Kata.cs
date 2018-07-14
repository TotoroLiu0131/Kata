using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace AnagramDetection
{
    public class Kata
    {
        public static bool IsAnagram(string test, string original)
        {
            return Concat(test.ToLower().OrderBy(x => x)) == Concat(original.ToLower().OrderBy(x => x));
        }
    }
}
