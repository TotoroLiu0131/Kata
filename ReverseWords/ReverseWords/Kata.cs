using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    public class Kata
    {
        public static string ReverseWords(string str)
        {
            var words = str.Split(' ').ToList();

            for (var i = 0; i < words.Count; i++)
            {
                words[i] = Reverse(words[i]);
            }

            return string.Join(" ", words);
        }

        private static string Reverse(string word)
        {
            return new string(word.ToCharArray().Reverse().ToArray());
        }
    }
}
